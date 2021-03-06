﻿/**********************************************************************
 * This class represents the wood class.
 * 
 * It performs all of the caluclations for the application and holds
 * the properties of the wood. 
 * 
 * Authors: Josh Houston, Nick McMahon, Eric Blumenstock, 
 * and Tianran Hao
 * 
 * Email: zjah82@goldmail.etsu.edu, mcmahonn@goldmail.etsu.edu,
 * blumenstock@goldmail.etsu.edu, haot01@goldmail.etsu.edu
 * 
**********************************************************************/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WoodWorksApp
{

    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new StartUpForm());
        }
    }

    public class Wood
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
        public double BeamShearFlat12Percent { get; private set; }
        public double BeamShearEdge12Percent { get; private set; }
        public double BeamShearFlatGreen { get; private set; }
        public double BeamShearEdgeGreen { get; private set; }
        public Category Category { get; private set; }

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
        /// <param name="BeamShearFlat12Percent">Flat beam shear value at 12 Elasticity</param>
        /// <param name="BeamShearEdge12Percent">Edge beam shear value 12 Elasticity</param>
        /// <param name="BeamShearFlatGreen">Edge beam shear value Green Elasticity</param>
        /// <param name="BeamShearEdgeGreen">Edge beam shear value Green Elasticity</param>
        /// <param name="Category">The category in the database</param>
        public Wood(int TreeId, string TreeName, string Description, double SpGravityGreen,
                    double SpGravity12Pct, double CoeffDimChgTang, double CoeffDimChgRadial,
                    double ElastGreen, double Elast12Pct, double BeamShearFlat12Percent, double BeamShearEdge12Percent,
                    double BeamShearFlatGreen, double BeamShearEdgeGreen, Category Category)
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
            this.BeamShearFlat12Percent = BeamShearFlat12Percent;
            this.BeamShearEdge12Percent = BeamShearEdge12Percent;
            this.BeamShearFlatGreen = BeamShearFlatGreen;
            this.BeamShearEdgeGreen = BeamShearEdgeGreen;
            this.Category = Category;
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
            //KB and KS constants 1/48 and 1/4
            const double KB = 0.020833333333;
			const double KS = 0.25;
		
			//Calculate beam moment of inertia
			// I = (b * h^3) / 12
			double inertia = (beamWidth * Math.Pow(beamDepth,3) / 12);
				
			//Calculate the modified beam area
			// A` = 5/6 * b * h				
			double area = ( 5.0 / 6.0) * beamWidth * beamDepth;
				
			//Calculate elasticity
			// E = ModulusOfElasticity
            double elasticity;
            if(elasticityIs12Pct)
			    elasticity = Elasticity12Percent;
            else
                elasticity = ElasticityGreen;
				
			//Calculate beam shear
			// beamShear/EL = BeamShearRatio
            double beamShear;
            if (beamShearIsFlat && elasticityIs12Pct)
                beamShear = BeamShearFlat12Percent;
            else if (beamShearIsFlat && !elasticityIs12Pct)
                beamShear = BeamShearFlatGreen;
            else if (elasticityIs12Pct && !beamShearIsFlat)
                beamShear = BeamShearEdge12Percent;
            else
                beamShear = BeamShearEdgeGreen;
				
			//Calculate beam deflection
			// beamDeflection = ((( KB * W * L^3 ) / (E * I )) + (( KS * W * L) / ( G * A` )))
            double beamDeflection =  (((KB * beamLoad * Math.Pow(beamSpan, 3)) / (elasticity * inertia)) +
				    ((KS * beamLoad * beamSpan)   / (beamShear * area)));
            return beamDeflection;
        }

        /// <summary>
        /// Calculates the moisture-driven dimensional change for some Wood object based on a final moisture content
        /// of 100% and an initial moisture content of 0%
        /// </summary>
        /// <param name="wood">The Wood object to perform the calculations upon</param>
        /// <param name="width">The width of the wood</param>
        /// <param name="direction">Radial or tangential direction of the wood</param>
        /// <returns>The change in dimension when moisture content changes from 10% to 35%</returns>
        public double calculateDimensionalChange(double width, Direction direction)
        {
            // Follows the formula deltaD = Di * (C * (Mf - Mi)) where deltaD is change in dimension,
            //      Di is initial dimension (width), C is the coefficient for dimensional change, which
            //      is determined by the direction, Mf is the final moisture content and Mi is the
            //      initial moisture content. 

            const int finalMoistureContent = 35;
            const int initialMoistureContent = 10;
            double coefficientForDimensioalChange = this.CoefficientDimmensionChangeTangential;
            if (direction == Direction.RADIAL)
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
        public double calculateDensityAtMositureContent(double specifiedM, string gravity)
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
            if (gravity == "12%")
                Gb = this.SpecificGravity12Percent;
            // calculates Gm
            Gm = (Gb / (1 - 0.265 * a * Gb));
            // calculates p
            p = 62.4 * Gm * (1 + M / 100);
            // returns the density
            return p;
        }

    }
}
