﻿using System;
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
    /// Interaction logic for AdminAddService.xaml
    /// </summary>
    public partial class AdminAddService : Window
    {
        public AdminAddService()
        {
            InitializeComponent();
        }

        public void AdminAddBackClick(object sender, RoutedEventArgs e)
        {
            AdminServicesPanel adminServicesPanel = new AdminServicesPanel();
            App.Current.MainWindow.Close();
            App.Current.MainWindow = adminServicesPanel;
            App.Current.MainWindow.Show();
        }

    }
}
