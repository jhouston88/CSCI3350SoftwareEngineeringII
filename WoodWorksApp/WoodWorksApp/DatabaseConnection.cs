﻿using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WoodWorksApp
{
    class DatabaseConnection
    {
        private string connectionString = @"DataSource=woodAppDBrev4.db; Version = 3; ";

        public string ConnectionString { get { return connectionString; } }

        /// <summary>
        /// Queries the database for the categories
        /// </summary>
        /// <returns>a list of categories</returns>
        public List<Category> getCategories()
        {
            List<Category> categories = new List<Category>();
           
            try
            {
                SQLiteConnection sqliteCon = new SQLiteConnection(this.connectionString);
                sqliteCon.Open();
                string query = "SELECT * FROM Category;";               // gets all of needed category info from the database
                SQLiteCommand createCommand = new SQLiteCommand(query, sqliteCon);
                SQLiteDataReader dr = createCommand.ExecuteReader();

                // Loop through the info returned from the database and add it to the categories list
                while (dr.Read())
                {
                    categories.Add(new Category(dr.GetInt32(0), dr.GetString(1)));
                }

                sqliteCon.Close();
            }
            catch (Exception ex)
            {
                throw (ex);
            }

            return categories;
        }

        public List<Wood> getWoodsInCategory(string category)
        {
            List<Wood> woods = new List<Wood>();

            try
            {
                SQLiteConnection sqliteCon = new SQLiteConnection(this.connectionString);
                sqliteCon.Open();
                // grab all the wood species from the database
                string query = "SELECT *  FROM Wood JOIN Category USING(cat_id) WHERE Category.category_name = '" + category + "';";
                SQLiteCommand createCommand = new SQLiteCommand(query, sqliteCon);
                SQLiteDataReader dr = createCommand.ExecuteReader();
                // add all the wood species in the database to the woods list
                while (dr.Read())
                {
                    woods.Add(new Wood(dr.GetInt32(0), dr.GetString(1), dr.GetString(2), dr.GetDouble(3), dr.GetDouble(4), dr.GetDouble(5), dr.GetDouble(6), dr.GetDouble(7), dr.GetDouble(8), dr.GetDouble(9), dr.GetDouble(10), new Category(dr.GetInt32(11), dr.GetString(12))));
                }
                sqliteCon.Close();
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return woods;
        }

        
    }
}
