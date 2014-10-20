using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.Windows.Forms;

namespace WoodWorks
{
    class DatabaseConnection
    {
        private string connectionString = @"Data Source = woodAppDBrev4.db; Version = 3; ";

        public string ConnectionString { get { return connectionString; } }

        public bool openDatabaseConnection()
        {
            SQLiteConnection sqliteConn = new SQLiteConnection(ConnectionString);
            bool connOpen = false;

            try
            {
                sqliteConn.Open();
                connOpen = true;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                connOpen = false;
            }
            return connOpen;
        }

        public bool closeDatabaseConnection()
        {
            SQLiteConnection sqliteConn = new SQLiteConnection(ConnectionString);
            bool connOpen = false;

            try
            {
                sqliteConn.Close();
                connOpen = true;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                connOpen = false;
            }
            return connOpen;
        }

        public string getCatagories()
        {
            SQLiteConnection sqliteCon = new SQLiteConnection(ConnectionString);
            string category_name = "";
            try
            {
                openDatabaseConnection();
                string query = "select category_name from Category;";
                SQLiteCommand createCommand = new SQLiteCommand(query, sqliteCon);

                SQLiteDataReader dr = createCommand.ExecuteReader();
                while (dr.Read())
                {
                    category_name = dr.GetString(0);
                }
                closeDatabaseConnection();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return category_name;
        }

        public Wood getTreesInCategory()
        {

        }

        public Wood getWood()
        {

        }
    }
}
