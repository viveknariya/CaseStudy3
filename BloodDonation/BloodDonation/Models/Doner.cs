using System;
using System.Collections.Generic;

namespace BloodDonation.Models
{
    public partial class Doner
    {
        public int Id { get; set; }
        public string DonerName { get; set; }
        public int? Age { get; set; }
        public string City { get; set; }
    }
}
