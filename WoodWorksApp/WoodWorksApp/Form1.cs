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
        private Category category;
        private Wood wood;


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
                string query = "SELECT * FROM Category;";

                // Passes the query and connection to the helper class
                SQLiteCommand createCommand = new SQLiteCommand(query, sqliteCon);

                // Helper class reads the data from database 
                SQLiteDataReader dr = createCommand.ExecuteReader();

                // While loops that readers the data from the data base and stores it in the CatName property
                while (dr.Read())
                {
                    category = new Category(dr.GetInt32(0), dr.GetString(1));
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

            if (catListBox.SelectedItem == null)
            {
                return;
            }
            // Get the current selected item in the Category List Box
            string curCategory = "";

            curCategory = catListBox.SelectedItem.ToString();
   
            // Query the database to select the tree name that matches the selected category
            string query = "SELECT * FROM Wood JOIN Category USING(cat_id) WHERE Category.category_name = '" + curCategory + "';";

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
                    wood = new Wood(dr.GetInt32(0), dr.GetString(1), dr.GetString(2), dr.GetDouble(3), dr.GetDouble(4), dr.GetDouble(5), dr.GetDouble(6), dr.GetDouble(7), dr.GetDouble(8), dr.GetDouble(9), dr.GetDouble(10), dr.GetInt32(11));
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
            // Ensures that a item from the list box is selected instead of white space
            if (speciesListBox.SelectedItem == null)
            {
                return;
            }
                // Add the description of the selected wood to the discription list box
                descripListBox.Text = wood.Description;

            }
        }
    }
