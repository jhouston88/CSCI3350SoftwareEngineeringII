using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WoodWorksApp
{
    public class Category
    {
        public int CategoryId { get; private set; }
        public string CategoryName { get; private set; }

        public Category(int CatId, string CatName)
        {
            this.CategoryId = CatId;
            this.CategoryName = CatName;
        }
    }
}
