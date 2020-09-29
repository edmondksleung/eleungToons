using System;
using System.Collections.Generic;

namespace lab3.ModelsToons
{
    public partial class VehicleManufacturers
    {
        public VehicleManufacturers()
        {
            Vehicles = new HashSet<Vehicles>();
        }

        public string VehicleManufacturerName { get; set; }
        public string Country { get; set; }

        public virtual ICollection<Vehicles> Vehicles { get; set; }
    }
}
