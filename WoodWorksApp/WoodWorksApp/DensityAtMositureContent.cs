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

        }
    }
}
