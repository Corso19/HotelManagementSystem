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
    public class AdminOfferViewModel : BaseVM
    {

        private ICommand m_deleteCommand;

        private OfferBBL offerBBL = new OfferBBL();

        private ObservableCollection<Offer> offersList { get; set; }
        public ObservableCollection<string> offers { get; set; }

        public int ID { get; set; }

        public AdminOfferViewModel()
        {
            ID = 0;
            offersList = offerBBL.GetAllOffers();
            offers = new ObservableCollection<string>();
            foreach (var offer in offersList)
            {
                offers.Add(offer.Name);
            }
        }

        public ICommand DeleteCommand
        {
            get
            {
                if (m_deleteCommand == null)
                    m_deleteCommand = new RelayCommand(DeleteOffer);
                return m_deleteCommand;
            }
        }

        public void DeleteOffer(object param)
        {
            offerBBL.DeleteOffer(offersList[ID]);
            offersList.Remove(offersList[ID]);

            offers.Remove(offers[ID]);
            OnPropertyChanged("features");

        }


    }
}
