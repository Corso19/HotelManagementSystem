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
    /// Interaction logic for AdminFeaturesPanel.xaml
    /// </summary>
    public partial class AdminFeaturesPanel : Window
    {
        public AdminFeaturesPanel()
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

        public void AdminAddFeatureClick(object sender, RoutedEventArgs e)
        {
            AdminAddFeature adminAddfeature = new AdminAddFeature();
            App.Current.MainWindow.Close();
            App.Current.MainWindow = adminAddfeature;
            App.Current.MainWindow.Show();
        }

        public void AdminUpdateFeatureClick(object sender, RoutedEventArgs e)
        {
            AdminUpdateFeature adminUpdateFeature = new AdminUpdateFeature();
            App.Current.MainWindow.Close();
            App.Current.MainWindow = adminUpdateFeature;
            App.Current.MainWindow.Show();
        }
    }
}
