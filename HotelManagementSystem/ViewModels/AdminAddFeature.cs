using HotelManagementSystem.Models;
using HotelManagementSystem.Models.BusinessLogicLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace HotelManagementSystem.ViewModels
{
    public class AdminAddFeature
    {

        private FeatureBBL featureBBL = new FeatureBBL();

        private ICommand m_addFeatureCommand;

        public ICommand AddFeatureCommand
        {
            get
            {
                if (m_addFeatureCommand == null)
                    m_addFeatureCommand = new RelayCommand(AddFeature);
                return m_addFeatureCommand;
            }
        }

        public string Name { get; set; }
        public string Description { get; set; }

        public void AddFeature(object param)
        {
            

            Feature newFeature = new Feature()
            {
                Name = Name,
                Description = Description,
                Deleted = false
            };

            featureBBL.AddFeature(newFeature);

        }

    }
}
