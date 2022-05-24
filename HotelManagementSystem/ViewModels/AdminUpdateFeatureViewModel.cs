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
    public class AdminUpdateFeatureViewModel : BaseVM
    {
        private FeatureBBL featureBBL = new FeatureBBL();

        private ICommand m_updateCommand;

        

        public string Name { get; set; }
        public string Description { get; set; }

        public void UpdateFeature(object param)
        {
            Feature newFeature = new Feature()
            {
                Name = Name,
                Description = Description,
                Deleted = false
            };

            featureBBL.UpdateFeature(newFeature);

        }

        public ICommand UpdateCommand
        {
            get
            {
                if (m_updateCommand == null)
                    m_updateCommand = new RelayCommand(UpdateFeature);
                return m_updateCommand;
            }
        }
    }
}
