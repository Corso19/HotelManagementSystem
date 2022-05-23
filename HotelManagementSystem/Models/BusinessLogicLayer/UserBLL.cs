using HotelManagementSystem.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManagementSystem.Models.BusinessLogicLayer
{
    class UserBLL
    {
        private HotelContext hotelContext = new HotelContext();
        public void SignIn(string email, string password)
        {
            try
            {
                var userQuery = (from user in hotelContext.Users
                                 where user.Email.Equals(email) && user.Password.Equals(password)
                                 select user).First();

               hotelContext.Users.Attach(userQuery);
               hotelContext.SaveChanges();
            }
            catch 
            {
                throw new Exception();
            }
        }

        public bool SignUp(string email,string username, string password, string firstname, string lastname)
        {
            var query = (from user in hotelContext.Users select user);

            foreach (var userInList in query)
            {
                if (userInList.Email.Contains(email))
                {
                    return false;
                }
            }

            User newUser = new User()
            {
                FirstName = firstname,
                LastName = lastname,
                Email = email,
                Password = password,
                Username = username
            };

            hotelContext.Users.Add(newUser);
            hotelContext.SaveChanges();
            return true;

        }
    }
}
