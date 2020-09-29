using System;
using System.Collections.Generic;

namespace lab3.ModelsToons
{
    public partial class Continents
    {
        public Continents()
        {
            Countries = new HashSet<Countries>();
        }

        public string ContinentName { get; set; }

        public virtual ICollection<Countries> Countries { get; set; }
    }
}
