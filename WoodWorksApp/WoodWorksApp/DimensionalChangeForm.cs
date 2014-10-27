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
    public partial class DimensionalChangeForm : Form
    {
        private Wood wood;

        public DimensionalChangeForm(Wood wood)
        {
            InitializeComponent();
            this.wood = wood;
        }

        private void DimensionalChangeForm_Load(object sender, EventArgs e)
        {
            woodLabel.Text = wood.TreeName + " " + wood.Category.CategoryName;
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            double width;
            // if the radial button isn't checked, then the tangential button must be checked.
            Wood.Direction direction = radialRadioButton.Checked ? Wood.Direction.RADIAL : Wood.Direction.TANGENTIAL;

            // make sure the user inputted a valid width.
            if (double.TryParse(widthTextBox.Text, out width) && width > 0)
            {
                resultTextBox.Text = wood.calculateDimensionalChange(width, direction).ToString();
            }
            else
            {
                MessageBox.Show("Width must be a positive number");
                resultTextBox.Text = String.Empty;
            }
        }

    }
}
