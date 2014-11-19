/**********************************************************************
 * This class represents the form to calculate the density at the 
 * specific moisture content.
 * 
 * It reads the type of woods passed through from the selected in 
 * the start up form, displays the name of the selected wood, and 
 * when the calculate button is clicked it calculates the density 
 * based on the moisture content entered by passes the the argument 
 * to the calculation class in the wood class. 
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
            //moistureContent.SelectedItem = moistureContent.Items[1];
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            // Because we have set the limit of value of M, so do not need to determine the value of M here. 
            double M = (double)valueM.Value;
            string gravity = TwelveradioButton.Checked ? "12%" : "Green";
            result.Text = wood.calculateDensityAtMositureContent(M, gravity).ToString();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
