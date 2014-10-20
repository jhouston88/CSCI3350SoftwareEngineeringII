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
        /// <returns>The change in dimension divided by the initial dimension - percent change</returns>
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
            
            // calculate deltaD and return deltaD/Di (see formula in previous comment)
            return (width * (coefficientForDimensioalChange * (finalMoistureContent - initialMoistureContent))); // / width;
        }

        /// <summary>
        /// Options for direction of wood grain. Used for the calculateDimensionalChange method" /> 
        /// </summary>
        public enum Direction
	    {
            RADIAL, TANGENTIAL     
	    }

        public double calculateDensityAtMositureContent()
        {
            double value = 0;

            return value;
        }
    }
}
