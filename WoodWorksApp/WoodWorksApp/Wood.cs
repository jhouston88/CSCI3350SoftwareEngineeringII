using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WoodWorksApp
{
    class Wood
    {
        public int TreeId { get; set; }
        public string TreeName { get; set; }
        public string Description { get; set; }
        public int SpGravityGreen { get; set; }
        public int SpGravity12Pct { get; set; }
        public int CoeffDimChgTang { get; set; }
        public int CoeffDimChgRadial { get; set; }
        public int ElastGreen { get; set; }
        public int Elast12Pct { get; set; }
        public int BeamShearFlat { get; set; }
        public int BeamShearEdge { get; set; }
        public int CatId { get; set; }
    }
}
