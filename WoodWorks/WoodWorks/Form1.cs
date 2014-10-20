using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WoodWorks
{
    public partial class Form1 : Form
    {
        DatabaseConnection db = new DatabaseConnection();
        public Form1()
        {
            InitializeComponent();

            db.getCatagories();

        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void speciesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void selectCalculationBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void catListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
