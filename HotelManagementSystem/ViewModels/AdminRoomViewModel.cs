using HotelManagementSystem.Models;
using HotelManagementSystem.Models.BusinessLogicLayer;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace HotelManagementSystem.ViewModels
{
    public class AdminRoomViewModel : BaseVM
    {

        private RoomBBL roomBBL = new RoomBBL();


        private ObservableCollection<Room> roomsList { get; set; }
        public ObservableCollection<string> rooms { get; set; }


        public int ID { get; set; }

        public AdminRoomViewModel()
        {
            ID = 0;
            roomsList = roomBBL.GetAllRooms();
            rooms = new ObservableCollection<string>();
            foreach (var room in roomsList)
            {
                rooms.Add(room.Number.ToString());
            }
        }

        private ICommand m_deleteCommand;

        public ICommand DeleteCommand
        {
            get
            {
                if (m_deleteCommand == null)
                    m_deleteCommand = new RelayCommand(DeleteRoom);
                return m_deleteCommand;
            }
        }


        public void DeleteRoom(object param)
        {
            roomBBL.DeleteRoom(roomsList[ID]);
            roomsList.Remove(roomsList[ID]);

            rooms.Remove(rooms[ID]);
            OnPropertyChanged("features");

        }



    }
}
