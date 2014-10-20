using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WoodWorksApp
{
    class WoodCalculations
    {

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
