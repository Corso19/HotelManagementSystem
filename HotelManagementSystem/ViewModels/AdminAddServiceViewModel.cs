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
    public class AdminAddServiceViewModel
    {

        private ServiceBBL serviceBBL = new ServiceBBL();

        private ICommand m_addServiceCommand;

        public ICommand AddServiceCommand
        {
            get
            {
                if (m_addServiceCommand == null)
                    m_addServiceCommand = new RelayCommand(AddService);
                return m_addServiceCommand;
            }
        }

        public string Name { get; set; }
        public string Description { get; set; }
        public int Price { get; set; }

        public void AddService(object param)
        {
            Service newService = new Service()
            {
                Name = Name,
                Description = Description,
                Price = Price
            };

            serviceBBL.AddService(newService);
            MessageBox.Show("Entry added in database!");
        }
    }
}
