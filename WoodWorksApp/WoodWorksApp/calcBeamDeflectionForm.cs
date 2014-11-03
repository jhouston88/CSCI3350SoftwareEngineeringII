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
            woodName.Text = wood.TreeName + " " + wood.Category;
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
            bool depthCheck = double.TryParse(beamWidthEntry.Text, out depth);

            double span;
            bool spanCheck = double.TryParse(beamWidthEntry.Text, out span);

            double load;
            bool loadCheck = double.TryParse(beamWidthEntry.Text, out load);

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

            resultDisplay.Text = wood.calculateBeamDeflection(width, depth, load, span, elasticityIs12percent, grainIsFlat).ToString();
        }

        
    }
}
