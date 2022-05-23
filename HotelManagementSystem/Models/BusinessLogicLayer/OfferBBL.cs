using HotelManagementSystem.Data;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManagementSystem.Models.BusinessLogicLayer
{
    class OfferBBL
    {

        private HotelContext hotelContext = new HotelContext();


        public void DeleteOffer(Offer offer)
        {

            offer.Deleted = true;
            hotelContext.SaveChanges();
        }

        public void AddOffer(Offer offer)
        {
            hotelContext.Offers.Add(offer);
            hotelContext.SaveChanges();
        }

        public ObservableCollection<Offer> GetAllOffers()
        {
            ObservableCollection<Offer> offers = new ObservableCollection<Offer>();

            var userQuery = (from offer in hotelContext.Offers select offer);

            foreach (var offer in userQuery)
            {
                if (offer.Deleted == false)
                    offers.Add(offer);
            }

            return offers;
        }

    }
}
