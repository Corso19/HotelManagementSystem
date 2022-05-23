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
    /// Interaction logic for AdminAddOffer.xaml
    /// </summary>
    public partial class AdminAddOffer : Window
    {
        public AdminAddOffer()
        {
            InitializeComponent();
        }

        public void AdminAddBackClick(object sender, RoutedEventArgs e)
        {
            AdminOffersPanel adminOffersPanel = new AdminOffersPanel();
            App.Current.MainWindow.Close();
            App.Current.MainWindow = adminOffersPanel;
            App.Current.MainWindow.Show();
        }


    }
}
