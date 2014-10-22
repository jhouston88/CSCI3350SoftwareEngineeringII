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
        public double SpGravityGreen { get; set; }
        public double SpGravity12Pct { get; set; }
        public double CoeffDimChgTang { get; set; }
        public double CoeffDimChgRadial { get; set; }
        public double ElastGreen { get; set; }
        public double Elast12Pct { get; set; }
        public double BeamShearFlat { get; set; }
        public double BeamShearEdge { get; set; }
        public int CatId { get; set; }


        /// <summary>
        /// Constructor
        /// </summary>
        public Wood()
        {
        }
        
        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="TreeId">The Tree ID in the database</param>
        /// <param name="TreeName">The name of the species</param>
        /// <param name="Description">Description of the species</param>
        /// <param name="SpGravityGreen">Specific Gravity Green value</param>
        /// <param name="SpGravity12Pct">Specific Gravity at 12% moisture value</param>
        /// <param name="CoeffDimChgTang">Coeefficient for dimensional change in the tangential direction</param>
        /// <param name="CoeffDimChgRadial">Coeefficient for dimensional change in the radial direction</param>
        /// <param name="ElastGreen">Elasticity green value</param>
        /// <param name="Elast12Pct">Elasticity at 12% moisture value</param>
        /// <param name="BeamShearFlat">Flat beam shear value</param>
        /// <param name="BeamShearEdge">Edge beam shear value</param>
        /// <param name="CatId">The category ID in the database</param>
        public Wood(int TreeId, string TreeName, string Description, double SpGravityGreen,
                    double SpGravity12Pct, double CoeffDimChgTang, double CoeffDimChgRadial,
                    double ElastGreen, double Elast12Pct, double BeamShearFlat, double BeamShearEdge,
                    int CatId)
        {
            this.TreeId = TreeId;
            this.TreeName = TreeName;
            this.Description = Description;
            this.SpGravityGreen = SpGravityGreen;
            this.SpGravity12Pct = SpGravity12Pct;
            this.CoeffDimChgTang = CoeffDimChgTang;
            this.CoeffDimChgRadial = CoeffDimChgRadial;
            this.ElastGreen = ElastGreen;
            this.Elast12Pct = Elast12Pct;
            this.BeamShearFlat = BeamShearFlat;
            this.BeamShearEdge = BeamShearEdge;
            this.CatId = CatId;
        }
    }
}
