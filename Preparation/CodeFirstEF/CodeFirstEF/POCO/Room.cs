using CodeFirstEF.Enums;
using System;

namespace CodeFirstEF.POCO
{
    public class Room
    {
        public Guid ID { get; set; }
        
        public Apartment MyApartment { get; set; }
        public RoomTypeEnum RoomType { get; set; }
        public string RoomName { get; set; }
    }
}
