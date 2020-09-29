﻿using System;
using System.Collections.Generic;

namespace lab3.ModelsToons
{
    public partial class Restaurants
    {
        public Restaurants()
        {
            MenuItems = new HashSet<MenuItems>();
        }

        public int RestaurantId { get; set; }
        public string RestaurantName { get; set; }
        public string Street { get; set; }
        public string City { get; set; }
        public string Province { get; set; }
        public string PostalCode { get; set; }
        public string Country { get; set; }
        public string FoodType { get; set; }

        public virtual ICollection<MenuItems> MenuItems { get; set; }
    }
}
