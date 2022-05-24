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
    public class AdminServicesViewModel : BaseVM
    {
        private ICommand m_deleteCommand;



        private ServiceBBL serviceBBL = new ServiceBBL();

        private ObservableCollection<Service> servicesList { get; set; }
        public ObservableCollection<string> services { get; set; }

        public int ID { get; set; }

        public AdminServicesViewModel()
        {
            ID = 0;
            servicesList = serviceBBL.GetAllServices();
            services = new ObservableCollection<string>();
            foreach (var service in servicesList)
            {
                services.Add(service.Name);
            }
        }

        public ICommand DeleteCommand
        {
            get
            {
                if (m_deleteCommand == null)
                    m_deleteCommand = new RelayCommand(DeleteService);
                return m_deleteCommand;
            }
        }

        public void DeleteService(object param)
        {
            serviceBBL.DeleteService(servicesList[ID]);
            servicesList.Remove(servicesList[ID]);

            services.Remove(services[ID]);
            OnPropertyChanged("services");

        }
    }
}
