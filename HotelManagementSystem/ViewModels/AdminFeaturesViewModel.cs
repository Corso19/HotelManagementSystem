using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using HotelManagementSystem.Models;
using HotelManagementSystem.Models.BusinessLogicLayer;

namespace HotelManagementSystem.ViewModels
{
    public class AdminFeaturesViewModel : BaseVM
    {
        private ICommand m_deleteCommand;
       
        

        private FeatureBBL featureBBL = new FeatureBBL();

        private ObservableCollection<Feature> featuresList { get; set; }
        public ObservableCollection<string> features { get; set; }

        public int ID { get; set; }

        public AdminFeaturesViewModel()
        {
            ID = 0;
            featuresList = featureBBL.GetAllFeatures();
            features = new ObservableCollection<string>();
            foreach(var feature in featuresList)
            {
                features.Add(feature.Name);
            }
        }

        public ICommand DeleteCommand
        {
            get
            {
                if (m_deleteCommand == null)
                    m_deleteCommand = new RelayCommand(DeleteFeature);
                return m_deleteCommand;
            }
        }

        

        

        public void DeleteFeature(object param)
        {
            featureBBL.DeleteFeature(featuresList[ID]);
            featuresList.Remove(featuresList[ID]);

            features.Remove(features[ID]);
            OnPropertyChanged("features");

        }

        

        
    }
}
