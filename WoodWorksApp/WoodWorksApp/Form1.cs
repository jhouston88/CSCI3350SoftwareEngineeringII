using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WoodWorksApp
{
    public partial class Form1 : Form
    {
        // Instantiate class objects 
        private DatabaseConnection DBConn = new DatabaseConnection();
        private List<Category> Categories;
        private List<Wood> Woods;
        private Wood Wood;


        public Form1()
        {
            InitializeComponent();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Populates the catListBox with all of the categories from the DB
            try
            {
                Categories = DBConn.getCategories();
                foreach (Category category in Categories)
                {
                    categoryListBox.Items.Add(category.CatName);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Could not load categories.");
                Environment.Exit(1);    // there's not point in continuing running if we have nothing to display.
            }
        }

        private void categoryListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (categoryListBox.SelectedItem == null)
            {
                return;
            }
            try
            {
                Woods = DBConn.getWoodsInCategory(categoryListBox.SelectedItem.ToString());
                descripListBox.Text = "";
                speciesListBox.Items.Clear();
                foreach (Wood wood in Woods)
                {
                    speciesListBox.Items.Add(wood.TreeName);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error getting the list o wood species for this category");
            }

        }

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
        }
    }
