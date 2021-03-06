﻿/**********************************************************************
 * This class represents the start up form. 
 * 
 * When the application is launched this is the first form that loads.
 * It querys the local database associated with it, and returns the 
 * category values. Upon selection of the desired categroies the 
 * wood species that belongs to that category appears. Upon selection
 * of the desired wood species, the description of the wood is
 * displayed. It also list the three calculations to perform on the 
 * selected wood species. In order for the calculation to be performed
 * a category and wood must be selected. 
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
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WoodWorksApp
{
    public partial class StartUpForm : Form
    {
        // Instantiate class objects 
        private DatabaseConnection DBConn = new DatabaseConnection();
        private List<Category> Categories;
        private List<Wood> Woods;
        private Wood Wood;
        private String[] Calculations;

        /// <summary>
        /// Launches when the form is initialized (before it's shown)
        /// </summary>
        public StartUpForm()
        {
            InitializeComponent();
            // associate the calculations listed in the combobox with the appropriate value so we can 
            // easily use them later to launch the forms.
            Calculations = new String[3]; 
            Calculations[(int)ComboBoxCalculations.BEAM_DEFLECTION] = "Beam Deflection";
            Calculations[(int)ComboBoxCalculations.DENSITY_AT_SPECIFIC_MOISTURE_CONTENT] = "Density at Specific Moisture Content";
            Calculations[(int)ComboBoxCalculations.MOISTURE_DRIVEN_DIMENSIONAL_CHANGE] = "Moisture Driven Dimensional Change";

            calculateComboBox.Items.AddRange(Calculations);

            Wood = null; 
        }
        
        /// <summary>
        /// Used to determine the calculations in the calculationsCombobox
        /// </summary>
        private enum ComboBoxCalculations
        {
            BEAM_DEFLECTION = 0, DENSITY_AT_SPECIFIC_MOISTURE_CONTENT, MOISTURE_DRIVEN_DIMENSIONAL_CHANGE
        }

        /// <summary>
        /// Launches when the main form is loaded, loads up the list of categories
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_Load(object sender, EventArgs e)
        {
            // Populates the categoryListBox with all of the categories from the DB
            try
            {
                Categories = DBConn.getCategories();
                foreach (Category category in Categories)
                {
                    categoryListBox.Items.Add(category.CategoryName);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Could not load categories.");
                Environment.Exit(1);
            }
        }

        /// <summary>
        /// Fired when the selected category is changed, updates the list of wood species accordingly.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void categoryListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (categoryListBox.SelectedItem == null)
            {
                return;
            }
            try
            {
                Woods = DBConn.getWoodsInCategory(categoryListBox.SelectedItem.ToString());
                speciesListBox.Items.Clear();
                foreach (Wood wood in Woods)
                {
                    speciesListBox.Items.Add(wood.TreeName);
                }
                Wood = null;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error getting the list of wood species for this category");
            }

        }

        /// <summary>
        /// Fired when a wood species is selected, displays a description of the wood species
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void speciesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Ensures that a item from the list box is selected instead of white space
            if (speciesListBox.SelectedItem == null)
            {
                return;
            }

            // get the appropriate wood species from the woods list
            Wood = Woods[speciesListBox.SelectedIndex];
            // Add the description of the selected wood to the discription list box
            descripListBox.Text = Wood.Description;

            }

        /// <summary>
        /// Fired when the calculate button is clicked, launches the form for the respective calculation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void calculateButton_Click(object sender, EventArgs e)
        {
            // no wood species selected yet
            if(Wood == null)
            {
                MessageBox.Show("You must select a wood species before performing a calculation", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            // no calculation selected
            if (calculateComboBox.SelectedIndex == -1)
            {
                MessageBox.Show("You must select a calculation first");
                return;
            }
            switch (calculateComboBox.SelectedIndex) 
            {
                case (int)ComboBoxCalculations.BEAM_DEFLECTION:
                    Form beamDeflectionForm = new calcBeamDeflectionForm(Wood);
                    beamDeflectionForm.Show();
                    break;

                case (int)ComboBoxCalculations.DENSITY_AT_SPECIFIC_MOISTURE_CONTENT:
                    Form densityAtMoistureContentForm = new DensityAtMositureContent(Wood);
                    densityAtMoistureContentForm.Show();
                    break;

                case (int)ComboBoxCalculations.MOISTURE_DRIVEN_DIMENSIONAL_CHANGE:
                    Form dimensionalChangeForm = new DimensionalChangeForm(Wood);
                    dimensionalChangeForm.Show();
                    break;

                // if someone gets here, then someone must have added a new calculation without updating the 
                //  ComboBoxCalculations enum or this switch statement.
                default:
                    MessageBox.Show("Invalid selection");
                    break;
            }
        }

        private void descripListBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void readMeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process process = new Process();
            ProcessStartInfo startInfo = new ProcessStartInfo();
            process.StartInfo = startInfo;

            startInfo.FileName = @".\Woodworks Read.pdf";
            process.Start();
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
     }
}
