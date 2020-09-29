﻿using System;
using System.Collections.Generic;

namespace lab3.ModelsToons
{
    public partial class Athletes
    {
        public int AthleteId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Country { get; set; }
        public int CompetitionId { get; set; }

        public virtual Competitions Competition { get; set; }
    }
}
