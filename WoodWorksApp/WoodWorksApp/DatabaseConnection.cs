using System;
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
        private string connectionString = @"Data Source = woodAppDBrev4.db; Version = 3; ";

        public string ConnectionString { get { return connectionString; } }

        Wood wood = new Wood();

        public void openDatabaseConnection()
        {
            SQLiteConnection sqliteConn = new SQLiteConnection(ConnectionString);

            try
            {
                sqliteConn.Open();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void closeDatabaseConnection()
        {
            SQLiteConnection sqliteConn = new SQLiteConnection(ConnectionString);

            try
            {
                sqliteConn.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        
    }
}
