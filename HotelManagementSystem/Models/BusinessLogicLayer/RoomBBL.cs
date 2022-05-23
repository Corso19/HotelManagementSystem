using HotelManagementSystem.Data;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManagementSystem.Models.BusinessLogicLayer
{
    class RoomBBL
    {

        private HotelContext hotelContext = new HotelContext();

        public void DeleteRoom(Room room)
        {

            room.Deleted = true;
            hotelContext.SaveChanges();
        }

        public void AddRoom(Room room)
        {
            hotelContext.Rooms.Add(room);
            hotelContext.SaveChanges();
        }

        public ObservableCollection<Room> GetAllRooms()
        {
            ObservableCollection<Room> rooms = new ObservableCollection<Room>();

            var userQuery = (from room in hotelContext.Rooms select room);

            foreach (var room in userQuery)
            {
                if (room.Deleted == false)
                    rooms.Add(room);
            }

            return rooms;
        }
    }
}
