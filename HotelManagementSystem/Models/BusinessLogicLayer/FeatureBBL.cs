using HotelManagementSystem.Data;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
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

        public static class DALHelper
        {
            private static readonly string connectionString = ConfigurationManager.ConnectionStrings["HotelManagementDB"].ConnectionString;

            public static SqlConnection Connection
            {
                get
                {
                    return new SqlConnection(connectionString);
                }
            }
        }

        public void UpdateFeature(Feature feature)
        {
            using (SqlConnection con = DALHelper.Connection)
            {
                SqlCommand cmd = new SqlCommand("ModifyFeatures", con);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlParameter Id = new SqlParameter("@Id", feature.Id);
                SqlParameter Name = new SqlParameter("@Name", feature.Name);
                SqlParameter Description = new SqlParameter("@Description", feature.Description);
                SqlParameter Deleted = new SqlParameter("@Deleted", feature.Deleted);
                cmd.Parameters.Add(Id);
                cmd.Parameters.Add(Name);
                cmd.Parameters.Add(Description);
                cmd.Parameters.Add(Deleted);
                con.Open();
                cmd.ExecuteNonQuery();
            }
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
