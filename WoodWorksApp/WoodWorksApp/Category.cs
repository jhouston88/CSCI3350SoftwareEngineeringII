﻿/**********************************************************************
 * This class represents the category class
 * 
 * It represents the properties of the Categories belonging to itself. 
 * 
 * Authors: Josh Houston, Nick McMahon, Eric Blumenstock, 
 * and Tianran Hao
 * 
 * Email: zjah82@goldmail.etsu.edu, mcmahonn@goldmail.etsu.edu,
 * blumenstock@goldmail.etsu.edu, haot01@goldmail.etsu.edu
 * 
**********************************************************************/

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
