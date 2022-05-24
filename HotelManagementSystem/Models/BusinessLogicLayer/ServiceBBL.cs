using HotelManagementSystem.Data;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManagementSystem.Models.BusinessLogicLayer
{
    class ServiceBBL
    {

        private HotelContext hotelContext = new HotelContext();

        public void DeleteService(Service service)
        {

            service.Deleted = true;
            hotelContext.SaveChanges();
        }

        public void AddService(Service service)
        {
            hotelContext.Services.Add(service);
            hotelContext.SaveChanges();
        }

        public ObservableCollection<Service> GetAllServices()
        {
            ObservableCollection<Service> services = new ObservableCollection<Service>();

            var userQuery = (from service in hotelContext.Services select service);

            foreach (var service in userQuery)
            {
                if (service.Deleted == false)
                    services.Add(service);
            }

            return services;
        }
    }
}
