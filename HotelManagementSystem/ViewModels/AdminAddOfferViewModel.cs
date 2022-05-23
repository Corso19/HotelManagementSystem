using HotelManagementSystem.Models;
using HotelManagementSystem.Models.BusinessLogicLayer;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace HotelManagementSystem.ViewModels
{
    public class AdminAddOfferViewModel : BaseVM
    {
        private OfferBBL offerBBL = new OfferBBL();

        private ObservableCollection<Offer> offersList { get; set; }
        public ObservableCollection<string> offers { get; set; }


        private ICommand m_addOfferCommand;

        public ICommand AddOfferCommand
        {
            get
            {
                if (m_addOfferCommand == null)
                    m_addOfferCommand = new RelayCommand(AddOffer);
                return m_addOfferCommand;
            }
        }

        public int ID { get; set; }

        public AdminAddOfferViewModel()
        {
            StartDate = DateTime.Now;
            EndDate = DateTime.Now;
          
        }

        public string Name { get; set; }
        public string Description { get; set; }

        public int RoomID { get; set; }

        public int Price { get; set; }

        
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }

        public ObservableCollection<Room> rooms;
        public ObservableCollection<string> roomsList { get; set; }

        



        public void AddOffer(object param)
        {
            Offer newOffer = new Offer();
            
            if(string.IsNullOrEmpty(Name))
            {
                MessageBox.Show("No name for offers");
                return;
            }
            newOffer.Name = Name;
            newOffer.Price = Price;
            newOffer.StartDate = StartDate;
          
            newOffer.EndDate = EndDate;
            newOffer.RoomId = RoomID;
            newOffer.Deleted = false;
            newOffer.Description = Description;
            offerBBL.AddOffer(newOffer);
            MessageBox.Show("Offer added succesfully");
            return;
        }
    }
}
