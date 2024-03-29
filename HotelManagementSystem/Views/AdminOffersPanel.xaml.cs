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
    /// Interaction logic for AdminOffersPanel.xaml
    /// </summary>
    public partial class AdminOffersPanel : Window
    {
        public AdminOffersPanel()
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

        public void AdminOfferAddClick(object sender, RoutedEventArgs e)
        {
            AdminAddOffer adminAddOffer = new AdminAddOffer();
            App.Current.MainWindow.Close();
            App.Current.MainWindow = adminAddOffer;
            App.Current.MainWindow.Show();
        }
        public void AdminOfferUpdateClick(object sender, RoutedEventArgs e)
        {
            AdminAddOffer adminAddOffer = new AdminAddOffer();
            App.Current.MainWindow.Close();
            App.Current.MainWindow = adminAddOffer;
            App.Current.MainWindow.Show();
        }
    }
}
