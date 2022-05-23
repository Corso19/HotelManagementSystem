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
    /// Interaction logic for AdminServicesPanel.xaml
    /// </summary>
    public partial class AdminServicesPanel : Window
    {
        public AdminServicesPanel()
        {
            InitializeComponent();
        }

        public void AdminPanelBack(object sender, RoutedEventArgs e)
        {
            AdminMenu adminMenu = new AdminMenu();
            App.Current.MainWindow.Close();
            App.Current.MainWindow = adminMenu;
            App.Current.MainWindow.Show();
        }

        public void AdminServicesAddClick(object sender, RoutedEventArgs e)
        {
            AdminAddService adminAddService = new AdminAddService();
            App.Current.MainWindow.Close();
            App.Current.MainWindow = adminAddService;
            App.Current.MainWindow.Show();
        }
    }
}
