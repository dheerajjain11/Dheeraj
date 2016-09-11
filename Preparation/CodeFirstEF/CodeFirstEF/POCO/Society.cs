using System;
using System.Collections.Generic;

namespace CodeFirstEF.POCO
{
    public class Society:ResidentialUnit
    {
        public string CGHSName { get; set; }
        public ICollection<Apartment> Apartments { get; set; }
    }
}
