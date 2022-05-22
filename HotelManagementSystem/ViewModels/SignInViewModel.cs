using HotelManagementSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace HotelManagementSystem.ViewModels
{
    public class SignInViewModel : BaseVM
    {
        User loggedUser = new User();
        
        public string email { get; set; }
        public string password { get; set; }

        private bool CanExecuteCommand { get; set; } = false;
        private ICommand m_signIn;



        public void signIn(object parameter)
        {
            if(string.IsNullOrEmpty(email))
        }

        public ICommand SignInCommand
        {
            get
            {
                if (m_signIn == null)
                    m_signIn = new RelayCommand(signIn);
                return m_signIn;
            }
            

        }
    }
}
