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
    /// Interaction logic for AdminAddFeature.xaml
    /// </summary>
    public partial class AdminAddFeature : Window
    {
        public AdminAddFeature()
        {
            InitializeComponent();
        }

        public void AdminAddBackClick(object sender, RoutedEventArgs e)
        {
            AdminFeaturesPanel adminFeaturesPanel = new AdminFeaturesPanel();
            App.Current.MainWindow.Close();
            App.Current.MainWindow = adminFeaturesPanel;
            App.Current.MainWindow.Show();
        }
    }
}
