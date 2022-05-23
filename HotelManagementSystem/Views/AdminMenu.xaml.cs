using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace HotelManagementSystem.Views
{
    /// <summary>
    /// Interaction logic for AdminMenu.xaml
    /// </summary>
    public partial class AdminMenu : Window
    {
        public AdminMenu()
        {
            InitializeComponent();
        }

        public void AdminMenuBackClick(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            App.Current.MainWindow.Close();
            App.Current.MainWindow = mainWindow;
            App.Current.MainWindow.Show();
        }

        public void OffersPanelClick(object sender, RoutedEventArgs e)
        {
            AdminOffersPanel adminOffersPanel = new AdminOffersPanel();
            App.Current.MainWindow.Close();
            App.Current.MainWindow = adminOffersPanel;
            App.Current.MainWindow.Show();
        }
        public void RoomPanelClick(object sender, RoutedEventArgs e)
        {
            AdminRoomPanel adminRoomPanel = new AdminRoomPanel();
            App.Current.MainWindow.Close();
            App.Current.MainWindow = adminRoomPanel;
            App.Current.MainWindow.Show();
        }
        public void ServicePanelClick(object sender, RoutedEventArgs e)
        {
            AdminServicesPanel adminServicesPanel = new AdminServicesPanel();
            App.Current.MainWindow.Close();
            App.Current.MainWindow = adminServicesPanel;
            App.Current.MainWindow.Show();
        }
        public void FeaturesPanelClick(object sender, RoutedEventArgs e)
        {
            AdminFeaturesPanel adminFeaturesPanel = new AdminFeaturesPanel();
            App.Current.MainWindow.Close();
            App.Current.MainWindow = adminFeaturesPanel;
            App.Current.MainWindow.Show();
        }

    }
}
