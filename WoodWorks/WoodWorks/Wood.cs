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

        public class WoodCalculations
        {
            public string Name {  get; set; }
            public string Category {  get;  set; }
            public double Moisture {  get;  set; }
            public string Description {  get;  set; }
            public int BeamWidith {  get;  set; }
            public int BeamDepth {  get;  set; }
            public int BeamLoad {  get;  set; }
            public int BeamSpan {  get;  set; }
            public string CategoryName {  get;  set; }
            public string TreeName {  get;  set; }
            public int SpGravityGreen {  get;  set; }
            public int SpGravity12Pct {  get;  set; }
            public int CoeffDimChgTang {  get;  set; }
            public int CoeffDimChgRadial {  get;  set; }


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
