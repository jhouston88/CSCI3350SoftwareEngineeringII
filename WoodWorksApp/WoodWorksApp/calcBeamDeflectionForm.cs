/**********************************************************************
 * This class represents form to calculate beam deflection.
 * 
 * It reads the type of wood that is passed from the startup form, 
 * initializes all of the fields in the form, and when the calculate
 * button is clicked it sets the values with the corresponding fields.
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
    public partial class calcBeamDeflectionForm : Form
    {
        private Wood wood;

        public calcBeamDeflectionForm(Wood wood)
        {
            InitializeComponent();
            this.wood = wood;
        }

        private void calcBeamDeflectionForm_Load(object sender, EventArgs e)
        {
            woodName.Text = wood.TreeName + " " + wood.Category.CategoryName;
            beamWidthEntry.Text = "0";
            beamDepthEntry.Text = "0";
            beamSpanEntry.Text = "0";
            beamLoadEntry.Text = "0";
            resultDisplay.Text = "0";
            radioFlat.Select();
            radioTwelvePct.Select();
            
        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            //These four parse the values then return true if parsing succeeded
            double width;
            bool widthCheck = double.TryParse(beamWidthEntry.Text, out width);
            
            double depth;
            bool depthCheck = double.TryParse(beamDepthEntry.Text, out depth);
            
            double span;
            bool spanCheck = double.TryParse(beamSpanEntry.Text, out span);

            double load;
            bool loadCheck = double.TryParse(beamLoadEntry.Text, out load);

            //Grain type radio button
            bool grainIsFlat;
            if (radioFlat.Checked)
                grainIsFlat = true;
            else
                grainIsFlat = false;

            //Moisture radio button
            bool elasticityIs12percent;
            if (radioTwelvePct.Checked)
                elasticityIs12percent = true;
            else
                elasticityIs12percent = false;

            //If all parsers returned true for no errors AND all variables are greater than zero ELSE display a message box
            if ((widthCheck && depthCheck && spanCheck && loadCheck) && (width > 0 && depth > 0 && load > 0 && span > 0))
                resultDisplay.Text = wood.calculateBeamDeflection(width, depth, load, span, elasticityIs12percent, grainIsFlat).ToString("0.###");
            else
            {
                MessageBox.Show("All entries must be positive numbers.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                resultDisplay.Text = String.Empty;
            }

            if (resultDisplay.Text == "Infinity")
            {
                MessageBox.Show("Wood species " + wood.TreeName + " has no beam shear for specified grain type and moisture content.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                resultDisplay.Text = String.Empty;
            }
        }
        
    }
}
