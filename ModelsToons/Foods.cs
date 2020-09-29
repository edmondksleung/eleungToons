using System;
using System.Collections.Generic;

namespace lab3.ModelsToons
{
    public partial class Foods
    {
        public int FoodId { get; set; }
        public string Name { get; set; }
        public string Unit { get; set; }
        public float UnitPrice { get; set; }
        public int FoodCategoryId { get; set; }

        public virtual FoodCategories FoodCategory { get; set; }
    }
}
