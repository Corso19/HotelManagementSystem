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
    /// Interaction logic for NoAccountRoomPanel.xaml
    /// </summary>
    public partial class NoAccountRoomPanel : Window
    {
        public NoAccountRoomPanel()
        {
            InitializeComponent();
        }

        private void NoAccountRoomBack(object sender, RoutedEventArgs e)
        {
            NoAccountMenu noAccountMenu = new NoAccountMenu();
            App.Current.MainWindow.Close();
            App.Current.MainWindow = noAccountMenu;
            App.Current.MainWindow.Show();
        }
    }
}
