using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WoodWorks
{
    static class Wood
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }

        public class Wood
        {
            public string Name { public get; private set; }
            public string Category { public get; private set; }
            public double Moisture { public get; private set; }
            public string Description { public get; private set; }
            public int BeamWidith { public get; private set; }
            public int BeamDepth { public get; private set; }
            public int BeamLoad { public get; private set; }
            public int BeamSpan { public get; private set; }
            public string CategoryName { public get; private set; }
            public string TreeName { public get; private set; }
            public int SpGravityGreen { public get; private set; }
            public int SpGravity12Pct { public get; private set; }
            public int CoeffDimChgTang { public get; private set; }
            public int CoeffDimChgRadial { public get; private set; }


            public double calculateBeamDeflection()
            {

            }

            public double calculateDimensionalChange()
            {

            }

            public double calculateDensityAtMositureContent()
            {

            }
        }
    }
}
