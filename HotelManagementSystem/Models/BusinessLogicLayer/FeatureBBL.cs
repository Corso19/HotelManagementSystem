using HotelManagementSystem.Data;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManagementSystem.Models.BusinessLogicLayer
{
    class FeatureBBL
    {
        private HotelContext hotelContext = new HotelContext();

        public void DeleteFeature(Feature feature)
        {

            feature.Deleted = true;
            hotelContext.SaveChanges();
        }

        public void AddFeature(Feature feature)
        {
            

            hotelContext.Features.Add(feature);
            hotelContext.SaveChanges();

        }

        public void UpdateFeature(Feature feature)
        {
            //hotelContext.Features.
        }

        public ObservableCollection<Feature> GetAllFeatures()
        {
            ObservableCollection<Feature> features = new ObservableCollection<Feature>();

            var userQuery = (from feature in hotelContext.Features select feature);

            foreach(var feature in userQuery)
            {
                if(feature.Deleted == false)
                    features.Add(feature);
            }

            return features;
        }

    }
}
