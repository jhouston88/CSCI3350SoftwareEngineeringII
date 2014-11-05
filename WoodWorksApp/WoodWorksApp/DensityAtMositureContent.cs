using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WoodWorksApp
{
    public partial class DensityAtMositureContent : Form
    {
        private Wood wood;
        public DensityAtMositureContent(Wood wood)
        {
            InitializeComponent();
            this.wood = wood;
        }

        private void DensityAtMositureContent_Load(object sender, EventArgs e)
        {
            woodName.Text = "Calculate the density of\r" + wood.TreeName + " " + wood.Category.CategoryName;
            moistureContent.SelectedItem = moistureContent.Items[1];
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            // Because we have set the limit of value of M, so do not need to determine the value of M here. 
            double M = (double)valueM.Value;
            string gravity = moistureContent.Text;
            result.Text = wood.calculateDensityAtMositureContent(M, gravity).ToString();
        }
    }
}
