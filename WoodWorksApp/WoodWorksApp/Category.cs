using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WoodWorksApp
{
    class Category
    {
        public int CatId { get; set; }
        public string CatName { get; set; }

        public Category()
        {
        }

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="CatId">The Category ID in the database</param>
        /// <param name="CatName">The name of the category</param>

        public Category(int CatId, string CatName)
        {
            this.CatId = CatId;
            this.CatName = CatName;
        }
    }
}
