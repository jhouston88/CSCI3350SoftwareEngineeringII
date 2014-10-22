using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WoodWorksApp
{
    class Wood
    {
        public int TreeId { get; set; }
        public string TreeName { get; set; }
        public string Description { get; set; }
        public double SpGravityGreen { get; set; }
        public double SpGravity12Pct { get; set; }
        public double CoeffDimChgTang { get; set; }
        public double CoeffDimChgRadial { get; set; }
        public double ElastGreen { get; set; }
        public double Elast12Pct { get; set; }
        public double BeamShearFlat { get; set; }
        public double BeamShearEdge { get; set; }
        public int CatId { get; set; }


        /// <summary>
        /// Constructor
        /// </summary>
        public Wood()
        {
        }
        
        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="TreeId">The Tree ID in the database</param>
        /// <param name="TreeName">The name of the species</param>
        /// <param name="Description">Description of the species</param>
        /// <param name="SpGravityGreen">Specific Gravity Green value</param>
        /// <param name="SpGravity12Pct">Specific Gravity at 12% moisture value</param>
        /// <param name="CoeffDimChgTang">Coeefficient for dimensional change in the tangential direction</param>
        /// <param name="CoeffDimChgRadial">Coeefficient for dimensional change in the radial direction</param>
        /// <param name="ElastGreen">Elasticity green value</param>
        /// <param name="Elast12Pct">Elasticity at 12% moisture value</param>
        /// <param name="BeamShearFlat">Flat beam shear value</param>
        /// <param name="BeamShearEdge">Edge beam shear value</param>
        /// <param name="CatId">The category ID in the database</param>
        public Wood(int TreeId, string TreeName, string Description, double SpGravityGreen,
                    double SpGravity12Pct, double CoeffDimChgTang, double CoeffDimChgRadial,
                    double ElastGreen, double Elast12Pct, double BeamShearFlat, double BeamShearEdge,
                    int CatId)
        {
            this.TreeId = TreeId;
            this.TreeName = TreeName;
            this.Description = Description;
            this.SpGravityGreen = SpGravityGreen;
            this.SpGravity12Pct = SpGravity12Pct;
            this.CoeffDimChgTang = CoeffDimChgTang;
            this.CoeffDimChgRadial = CoeffDimChgRadial;
            this.ElastGreen = ElastGreen;
            this.Elast12Pct = Elast12Pct;
            this.BeamShearFlat = BeamShearFlat;
            this.BeamShearEdge = BeamShearEdge;
            this.CatId = CatId;
        }

        public double calculateBeamDeflection()
        {
            double value = 0;

            return value;
        }

        /// <summary>
        /// Calculates the moisture-driven dimensional change for some Wood object based on a final moisture content
        /// of 100% and an initial moisture content of 0%
        /// </summary>
        /// <param name="wood">The Wood object to perform the calculations upon</param>
        /// <param name="width">The width of the wood</param>
        /// <param name="direction">Radial or tangential direction of the wood</param>
        /// <returns>The change in dimension when moisture content changes from 0% to 100%</returns>
        public static double calculateDimensionalChange(Wood wood, double width, Direction direction)
        {
            // Follows the formula deltaD = Di * (C * (Mf - Mi)) where deltaD is change in dimension,
            //      Di is initial dimension (width), C is the coefficient for dimensional change, which
            //      is determined by the direction, Mf is the final moisture content and Mi is the
            //      initial moisture content. 

            const int finalMoistureContent = 100;                           // set to 100% as we want the full range
            const int initialMoistureContent = 0;                           // set to 0% as we want the full range
            double coefficientForDimensioalChange = wood.CoeffDimChgTang;   // assume we're being passed a tangential direction
            if (direction == Direction.RADIAL)                              // but if we're not, switch to coefficent for radial direction
                coefficientForDimensioalChange = wood.CoeffDimChgRadial;

            // calculate deltaD and return deltaD (see formula in previous comment)
            return width * (coefficientForDimensioalChange * (finalMoistureContent - initialMoistureContent));
        }

        /// <summary>
        /// Options for direction of wood grain. Used for the calculateDimensionalChange method" /> 
        /// </summary>
        public enum Direction
        {
            RADIAL, TANGENTIAL
        }

        public static double calculateDensityAtMositureContent(Wood wood, double specifiedM, Gravity gravity)
        {
            // Three steps to get the density
            // First, calculates the a via using a = (30 - M) / 30 where M is determined by the user and its default value is 20
            // Second, calculates the Gm via using Gm = (Gb / (1 - 0.265 * a * Gb)). 
            // For this step, there are two conditions, one is green and another is 12% moisture content.
            // The condition will be decided by the user.
            // Third, calculates the p via using p = 62.4 * Gm * (1 + M / 100)
            double M = 20, a = 0, Gb = wood.SpGravityGreen, Gm = 0, p = 0;

            // gets the value of M
            M = specifiedM;
            // calculates a
            a = (30 - M) / 30;
            // changes the value of Gb if the condition is 12% moisture content
            if (gravity == Gravity.TWELVEPCT)
                Gb = wood.SpGravity12Pct;
            // calculates Gm
            Gm = (Gb / (1 - 0.265 * a * Gb));
            // calculates p
            p = 62.4 * Gm * (1 + M / 100);
            // returns the density
            return p;
        }

        // Method used for the density calculation
        public enum Gravity
        {
            GREEN, TWELVEPCT
        }
    }
}
