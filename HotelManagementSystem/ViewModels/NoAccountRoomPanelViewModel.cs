using HotelManagementSystem.Models;
using HotelManagementSystem.Models.BusinessLogicLayer;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManagementSystem.ViewModels
{
    public class NoAccountRoomPanelViewModel :BaseVM
    {
        private RoomBBL roomBBL = new RoomBBL();


        private ObservableCollection<Room> roomsList { get; set; }
        public ObservableCollection<string> rooms { get; set; }


        public int ID { get; set; }

        public NoAccountRoomPanelViewModel()
        {
            ID = 0;
            roomsList = roomBBL.GetAllRooms();
            rooms = new ObservableCollection<string>();
            foreach (var room in roomsList)
            {
                rooms.Add(room.Number.ToString());
            }
        }
    }
}
