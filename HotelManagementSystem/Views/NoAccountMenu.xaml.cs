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
    /// Interaction logic for NoAccountMenu.xaml
    /// </summary>
    public partial class NoAccountMenu : Window
    {
        public NoAccountMenu()
        {
            InitializeComponent();
        }

        private void BackToMainClick(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            App.Current.MainWindow.Close();
            App.Current.MainWindow = mainWindow;
            App.Current.MainWindow.Show();
        }

        private void NoAccountRoomClick(object sender, RoutedEventArgs e)
        {
            NoAccountRoomPanel noAccountRoomPanel = new NoAccountRoomPanel();
            App.Current.MainWindow.Close();
            App.Current.MainWindow = noAccountRoomPanel;
            App.Current.MainWindow.Show();
        }

        private void NoAccountInfoClick(object sender, RoutedEventArgs e)
        {
            NoAccountInformation noAccountInformation = new NoAccountInformation();
            App.Current.MainWindow.Close();
            App.Current.MainWindow = noAccountInformation;
            App.Current.MainWindow.Show();
        }
    }
}
