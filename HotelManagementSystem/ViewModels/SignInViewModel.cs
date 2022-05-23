using HotelManagementSystem.Models;
using HotelManagementSystem.Models.BusinessLogicLayer;
using HotelManagementSystem.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace HotelManagementSystem.ViewModels
{
    public class SignInViewModel : BaseVM
    {
        private string email;
        public string Email
        {
            get
            {
                return email;
            }
            set
            {
                email = value;
                ErrorMessage = "";
                Regex regex = new Regex(@"^[A-Za-z0-9._]+@[A-Za-z0-9.-]+\.[A-Za-z]{2,}$");
                if (regex.Match(Email) == Match.Empty)
                {
                    ErrorMessage = "INVALID EMAIL FORMAT";
                    CanExecuteCommand = false;
                }
                else
                {
                    CanExecuteCommand = true;
                }
                OnPropertyChanged("Email");
            }
        }

        private string errorMessage;
        public string ErrorMessage
        {
            get
            {
                return errorMessage;
            }
            set
            {
                errorMessage = value;
                OnPropertyChanged("ErrorMessage");
            }
        }

        public bool CanExecuteCommand { get; set; } = false;

        private ICommand signInCommand;
        public ICommand SignInCommand
        {
            get
            {
                if (signInCommand == null)
                {
                    signInCommand = new RelayCommand(SignIn);
                }
                return signInCommand;
            }
        }

        public void SignIn(object param)
        {
            string password = (param as PasswordBox).Password;
            if (password.Length == 0)
            {
                MessageBox.Show("Enter your password");
            }
            else
            {
                UserBLL user = new UserBLL();
                try
                {
                    user.SignIn(Email, password);
                    Regex regex = new Regex(@"@hotelmanager.com$|@hotelstaff.com$");
                    if (regex.Match(Email) != Match.Empty)
                    {
                        AdminMenu adminMenu = new AdminMenu();
                        App.Current.MainWindow.Close();
                        App.Current.MainWindow = adminMenu;
                        App.Current.MainWindow.Show();
                    }
                    else
                    {
                        LoggedMenu loggedMenu = new LoggedMenu();
                        App.Current.MainWindow.Close();
                        App.Current.MainWindow = loggedMenu;
                        App.Current.MainWindow.Show();
                    }
                }
                catch
                {
                    MessageBox.Show("Incorrect email or password!");
                }
            }
        }
    }
}
