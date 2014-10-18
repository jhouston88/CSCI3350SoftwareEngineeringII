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
        public string ConnectionString { public get; private set; }

        public bool openDatabaseConnection()
        {
            ConnectionString = @"Data Source = woodAppDBrev4.db; Version = 3; ";
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

        }

        public string getCatagories()
        {

        }

        public Wood getTreesInCategory()
        {

        }

        public Wood getWood()
        {

        }
    }
}
