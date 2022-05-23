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
    public class SignUpViewModel : BaseVM
    {

        //private bool CanExecuteCommand { get; set; } = false;
        //private ICommand signUpCommand;
        //public ICommand SignUpCommand
        //{
        //    get
        //    {
        //        if (signUpCommand == null)
        //        {
        //            signUpCommand = new RelayCommand(SignUp);
        //        }
        //        return signUpCommand;
        //    }
        //}

        //public void SignUp(object param)
        //{
        //    string password = (param as PasswordBox).Password;

        //    Regex regex = new Regex(@"@steak-house.com$|@steakhouse.com$");
        //    if (regex.Match(email) != Match.Empty)
        //    {
        //        MessageBox.Show("Only the admin can create\nan employee account!", "Account creation failed", MessageBoxButton.OK, MessageBoxImage.Error);
        //    }
        //    else
        //    {
        //        UserBLL user = new UserBLL();
        //        if (!user.SignUp(email, username, password, firstname, lastname))
        //        {
        //            MessageBox.Show("There is already an account with this email");
        //        }
        //        else
        //        {
        //            MainWindow mainWindow = new MainWindow();
        //            App.Current.MainWindow.Close();
        //            App.Current.MainWindow = mainWindow;
        //            App.Current.MainWindow.Show();
        //        }
        //    }
        //}

    }
}
