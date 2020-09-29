using System;
using System.Collections.Generic;

namespace lab3.ModelsToons
{
    public partial class FoodCategories
    {
        public FoodCategories()
        {
            Foods = new HashSet<Foods>();
        }

        public int FoodCategoryId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public virtual ICollection<Foods> Foods { get; set; }
    }
}
