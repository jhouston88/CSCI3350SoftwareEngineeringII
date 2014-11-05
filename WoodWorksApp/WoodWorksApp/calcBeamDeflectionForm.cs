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
            moistureContent.SelectedItem = moistureContent.Items[0];
            grainType.SelectedItem = grainType.Items[0];
            beamWidthEntry.Text = "0";
            beamDepthEntry.Text = "0";
            beamSpanEntry.Text = "0";
            beamLoadEntry.Text = "0";
            resultDisplay.Text = "0";
            
        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            double width;
            bool widthCheck = double.TryParse(beamWidthEntry.Text, out width);
            
            double depth;
            bool depthCheck = double.TryParse(beamDepthEntry.Text, out depth);
            
            double span;
            bool spanCheck = double.TryParse(beamSpanEntry.Text, out span);

            double load;
            bool loadCheck = double.TryParse(beamLoadEntry.Text, out load);

            bool grainIsFlat;
            if (grainType.SelectedItem.ToString() == "Flat")
                grainIsFlat = true;
            else
                grainIsFlat = false;

            bool elasticityIs12percent;
            if (moistureContent.SelectedItem.ToString() == "12%")
                elasticityIs12percent = true;
            else
                elasticityIs12percent = false;

            //If all parsers returned true for no errors AND all variables are greater than zero ELSE display a message box
            if ((widthCheck && depthCheck && spanCheck && loadCheck) && (width > 0 && depth > 0 && load > 0 && span > 0))
                resultDisplay.Text = wood.calculateBeamDeflection(width, depth, load, span, elasticityIs12percent, grainIsFlat).ToString();
            else
            {
                MessageBox.Show("All entries must be positive numbers.");
                resultDisplay.Text = String.Empty;
            }
        }
        
    }
}
