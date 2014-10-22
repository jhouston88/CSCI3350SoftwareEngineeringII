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
        private DatabaseConnection dbConn = new DatabaseConnection();
        private WoodCalculations woodCalc = new WoodCalculations();
        private Category category = new Category();
        private Wood wood = new Wood(); 


        public Form1()
        {
            InitializeComponent();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Populates the catListBox with all of the categories from the DB
            getCatagories();
        }

        private void getCatagories()
        {
            SQLiteConnection sqliteCon = new SQLiteConnection(dbConn.ConnectionString);

            try
            {
                // Open connection to database
                sqliteCon.Open();

                // Querys the category name from the Category table
                string query = "SELECT category_name FROM Category;";

                // Passes the query and connection to the helper class
                SQLiteCommand createCommand = new SQLiteCommand(query, sqliteCon);

                // Helper class reads the data from database 
                SQLiteDataReader dr = createCommand.ExecuteReader();

                // While loops that readers the data from the data base and stores it in the CatName property
                while (dr.Read())
                {
                    category.CatName = dr.GetString(0);
                    catListBox.Items.Add(category.CatName);
                }
                // Closes the database connection
                sqliteCon.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private void catListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            SQLiteConnection sqliteCon = new SQLiteConnection(dbConn.ConnectionString);
            // Get the current selected item in the Category List Box
            string curCategory = "";
            if (catListBox == null)
            {
                catListBox.Items.Add("List box is empty");
            }
            else if (catListBox.SelectedItem.Equals(null))
            {
                MessageBox.Show("Please Select an Item from list");
            }
            else
            {
                curCategory = catListBox.SelectedItem.ToString();
            }
            // Query the database to select the tree name that matches the selected category
            string query = "SELECT tree_name FROM Wood JOIN Category USING(cat_id) WHERE Category.category_name = '" + curCategory + "';";

            // Passes the query and connection to the helper class
            SQLiteCommand createCommand = new SQLiteCommand(query, sqliteCon);

            // Helper class reads the data from database 
            SQLiteDataReader dr;

            try
            {
                descripListBox.Text = "";
                speciesListBox.Items.Clear();
                sqliteCon.Open();
                dr = createCommand.ExecuteReader();
                // While loops that readers the data from the data base and stores it in the CatName property
                while (dr.Read())
                {
                    wood.TreeName = dr.GetString(0);
                    speciesListBox.Items.Add(wood.TreeName);
                    
                }
                // Closes the database connection
                sqliteCon.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void descripListBox_SelectedIndexChanged(object sender, EventArgs e)
        {


        }

        private void speciesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            SQLiteConnection sqliteCon = new SQLiteConnection(dbConn.ConnectionString);
            // Get the current select item in the Species list box
            string curSpecies = speciesListBox.SelectedItem.ToString();
            // Get the current selected item in the Category List Box
            string curCategory = catListBox.SelectedItem.ToString();
            // Query the database to select the description that matches the selected species
            string query = "SELECT description FROM Wood JOIN Category USING(cat_id) WHERE tree_name = '" + curSpecies + "' AND category_name = '" + curCategory + "';";

            // Passes the query and connection to the helper class
            SQLiteCommand createCommand = new SQLiteCommand(query, sqliteCon);

            // Helper class reads the data from database 
            SQLiteDataReader dr;
            try
            {
                descripListBox.Text = ""; 
                sqliteCon.Open();
                dr = createCommand.ExecuteReader();
                // While loops that readers the data from the data base and stores it in the CatName property
                while (dr.Read())
                {
                    wood.Description = dr.GetString(0);
                    descripListBox.Text = wood.Description;

                }
                // Closes the database connection
                sqliteCon.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
