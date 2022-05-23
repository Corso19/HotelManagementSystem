using HotelManagementSystem.Models;
using HotelManagementSystem.Models.BusinessLogicLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace HotelManagementSystem.ViewModels
{
    public class AdminAddRoomViewModel
    {

        private RoomBBL roomBBL = new RoomBBL();

        private ICommand m_addRoomCommand;

        public ICommand AddRoomCommand
        {
            get
            {
                if (m_addRoomCommand == null)
                    m_addRoomCommand = new RelayCommand(AddRoom);
                return m_addRoomCommand;
            }
        }

        public int Number { get; set; }
        public int Floor { get; set; }

        public void AddRoom(object param)
        {
            Room newRoom = new Room()
            {
                Number = Number,
                Floor = Floor
            };

            roomBBL.AddRoom(newRoom);
            MessageBox.Show("Entry added in database!");
        }
    }
}
