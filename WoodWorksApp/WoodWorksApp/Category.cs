using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WoodWorksApp
{
    class Category
    {
        public int CatId { get; private set; }
        public string CatName { get; private set; }

        public Category(int CatId, string CatName)
        {
            this.CatId = CatId;
            this.CatName = CatName;
        }



    }
}
