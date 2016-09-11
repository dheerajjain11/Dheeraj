using System;
using System.Collections.Generic;

namespace CodeFirstEF.POCO
{
    public class Apartment:ResidentialUnit
    { 
        public string Block { get; set; }
        public string OwnerName { get; set; }

        public Society HousingSociety { get; set; }

        public ICollection<Room> Rooms;
    }
}
