using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WoodWorksApp
{
    class Wood
    {
        public int TreeId {  get; private set; }
        public string TreeName { get; private set; }
        public string Description { get; private set; }
        public double SpecificGravityGreen { get; private set; }
        public double SpecificGravity12Percent { get; private set; }
        public double CoefficientDimmensionChangeTangential { get; private set; }
        public double CoefficientDimmensionChangeRadial { get; private set; }
        public double ElasticityGreen { get; private set; }
        public double Elasticity12Percent { get; private set; }
        public double BeamShearFlat { get; private set; }
        public double BeamShearEdge { get; private set; }
        public int CatId { get; private set; }


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
            this.SpecificGravityGreen = SpGravityGreen;
            this.SpecificGravity12Percent = SpGravity12Pct;
            this.CoefficientDimmensionChangeTangential = CoeffDimChgTang;
            this.CoefficientDimmensionChangeRadial = CoeffDimChgRadial;
            this.ElasticityGreen = ElastGreen;
            this.Elasticity12Percent = Elast12Pct;
            this.BeamShearFlat = BeamShearFlat;
            this.BeamShearEdge = BeamShearEdge;
            this.CatId = CatId;
        }

        /// <summary>
        /// Calculates the beam deflection of a specified width, depth, span, and weight load of wood.
        /// </summary>
        /// <param name="beamWidth">Width of the wood beam</param>
        /// <param name="beamDepth">Depth of the wood beam</param>
        /// <param name="beamLoad">Load in pounds (lbs) on top of the wood beam</param>
        /// <param name="beamSpan">Span of the wood beam</param>
        /// <param name="elasticityIs12Pct">Specifies if the modulus of elasticity being used is 12 percent or green</param>
        /// <param name="beamShearIsFlat">Specifies if the beam shear in question is flat or edge</param>
        /// <returns>The change in dimension when moisture content changes from 0% to 100%</returns>
        public double calculateBeamDeflection(double beamWidth, double beamDepth, double beamLoad, double beamSpan, bool elasticityIs12Pct, bool beamShearIsFlat)
        {
            //KB and KS constants
			const double KB = 0.020833333333;	// 1/48
			const double KS = 0.25;				// 1/4
		
			//Calculate beam moment of inertia
			// I = (b * h^3) / 12
			double inertia = (beamWidth * Math.Pow(beamDepth,3) / 12);
				
			//Calculate the modified beam area
			// A` = 5/6 * b * h				
			double area = 5 / 6 * beamWidth * beamDepth;
				
			//Calculate elasticity
			// E = ModulusOfElasticity * 110%
            double elasticity;
            if(elasticityIs12Pct)
			    elasticity = Elasticity12Percent * 1.10;
            else
                elasticity = ElasticityGreen * 1.10;
				
			//Calculate beam shear
			// beamShear/EL = BeamShearRatio
            double beamShear;
			if (beamShearIsFlat)
                beamShear = BeamShearFlat * elasticity;
            else
                beamShear = BeamShearEdge * elasticity;
				
			//Calculate beam deflection
			// beamDeflection = ((( KB * W * L^3 ) / (E * I )) + (( KS * W * L) / ( G * A` )))
            return (((KB * beamLoad * Math.Pow(beamSpan, 3)) / (elasticity * inertia)) +
					((KS * beamLoad * beamSpan)   / (beamShear / area)));
        }

        /// <summary>
        /// Calculates the moisture-driven dimensional change for some Wood object based on a final moisture content
        /// of 100% and an initial moisture content of 0%
        /// </summary>
        /// <param name="wood">The Wood object to perform the calculations upon</param>
        /// <param name="width">The width of the wood</param>
        /// <param name="direction">Radial or tangential direction of the wood</param>
        /// <returns>The change in dimension when moisture content changes from 0% to 100%</returns>
        public double calculateDimensionalChange(double width, Direction direction)
        {
            // Follows the formula deltaD = Di * (C * (Mf - Mi)) where deltaD is change in dimension,
            //      Di is initial dimension (width), C is the coefficient for dimensional change, which
            //      is determined by the direction, Mf is the final moisture content and Mi is the
            //      initial moisture content. 

            const int finalMoistureContent = 100;                           // set to 100% as we want the full range
            const int initialMoistureContent = 0;                           // set to 0% as we want the full range
            double coefficientForDimensioalChange = this.CoefficientDimmensionChangeTangential;   // assume we're being passed a tangential direction
            if (direction == Direction.RADIAL)                              // but if we're not, switch to coefficent for radial direction
                coefficientForDimensioalChange = this.CoefficientDimmensionChangeRadial;

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

        /// <summary>
        /// Calculates the density at a specified moisture
        /// </summary>
        /// <param name="specifiedM">The moisture content</param>
        /// <param name="gravity">The type of gravity</param>
        /// <returns></returns>
        public double calculateDensityAtMositureContent(double specifiedM, Gravity gravity)
        {
            // Three steps to get the density
            // First, calculates the a via using a = (30 - M) / 30 where M is determined by the user and its default value is 20
            // Second, calculates the Gm via using Gm = (Gb / (1 - 0.265 * a * Gb)). 
            // For this step, there are two conditions, one is green and another is 12% moisture content.
            // The condition will be decided by the user.
            // Third, calculates the p via using p = 62.4 * Gm * (1 + M / 100)
            double M = 20, a = 0, Gb = this.SpecificGravityGreen, Gm = 0, p = 0;

            // gets the value of M
            M = specifiedM;
            // calculates a
            a = (30 - M) / 30;
            // changes the value of Gb if the condition is 12% moisture content
            if (gravity == Gravity.TWELVEPERCENT)
                Gb = this.SpecificGravity12Percent;
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
            GREEN, TWELVEPERCENT
        }
    }
}
