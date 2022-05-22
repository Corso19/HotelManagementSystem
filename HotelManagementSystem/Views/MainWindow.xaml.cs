using HotelManagementSystem.Data;
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
using System.Windows.Navigation;
using System.Windows.Shapes;
using HotelManagementSystem.Models;

namespace HotelManagementSystem.Views
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private readonly HotelContext _hotelContext = new HotelContext();

        public MainWindow()
        {
            InitializeComponent();
            //_hotelContext.Users.Add(new User{
            //    Email = "stefan@gmail.com",
            //    FirstName = "Stefan",
            //    LastName = "Acatrinei",
            //    Password = "1234",
            //    Username = "stefan123"

            //});
            //_hotelContext.SaveChanges();
        }

        private void SignInClick(object sender, RoutedEventArgs e)
        {
            SignIn signIn = new SignIn();
            App.Current.MainWindow.Close();
            App.Current.MainWindow = signIn;
            App.Current.MainWindow.Show();
        }

        private void SignUpClick(object sender, RoutedEventArgs e)
        {
            SignUp signUp = new SignUp();
            App.Current.MainWindow.Close();
            App.Current.MainWindow = signUp;
            App.Current.MainWindow.Show();
        }

        private void NoAccountClick(object sender, RoutedEventArgs e)
        {
            NoAccountMenu noAccountMenu = new NoAccountMenu();
            App.Current.MainWindow.Close();
            App.Current.MainWindow= noAccountMenu;
            App.Current.MainWindow.Show();
        }
    }
}
