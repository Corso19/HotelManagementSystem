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
    /// Interaction logic for AdminRoomPanel.xaml
    /// </summary>
    public partial class AdminRoomPanel : Window
    {
        public AdminRoomPanel()
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
        public void AdminRoomAddClick(object sender, RoutedEventArgs e)
        {
            AdminAddRoom adminAddRoom = new AdminAddRoom();
            App.Current.MainWindow.Close();
            App.Current.MainWindow = adminAddRoom;
            App.Current.MainWindow.Show();
        }

    }
}
