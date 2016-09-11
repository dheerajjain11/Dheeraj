using System;
using System.Collections.Generic;

using CodeFirstEF.Enums;
using CodeFirstEF.POCO;

namespace CodeFirstEF
{
    public class CreatorCode
    {
        public static Society Create(string name)
        {
            Society mySociety = new Society();
            mySociety.Name = name;
            mySociety.ID = Guid.NewGuid();
            mySociety.Apartments = new List<Apartment>();
            //create some apartments

            Apartment apartment1 = new Apartment();
            apartment1.HousingSociety = mySociety;
            apartment1.OwnerName = "RDR";
            apartment1.Block = "D";
            apartment1.ID = Guid.NewGuid();

            apartment1.Rooms = new List<Room>();

            Room room1 = new Room();
            room1.ID = Guid.NewGuid();
            room1.MyApartment = apartment1;
            room1.RoomType = RoomTypeEnum.DrawingRoom;
            apartment1.Rooms.Add(room1);

            Room room2 = new Room();
            room2.ID = Guid.NewGuid();
            room2.MyApartment = apartment1;
            room2.RoomType = RoomTypeEnum.DiningRoom;
            apartment1.Rooms.Add(room2);


            mySociety.Apartments.Add(apartment1);

            return mySociety;
        }
    }
}
