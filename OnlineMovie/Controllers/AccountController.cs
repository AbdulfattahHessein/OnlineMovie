using OnlineMovie.Models;
using OnlineMovie.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineMovie.Controllers
{
    public static class AccountController
    {
        public static void Registration()
        {
            try
            {
                var customer = AccountViews.Registration();

                Context.Users.Save(customer);
            }
            catch (Exception e)
            {

                Console.WriteLine(e.Message);
            }
        }
        public static User? Login()
        {
            try
            {
                var loginUser = AccountViews.Login();
                var user = Context.Users.FirstOrDefault(u => u.Username == loginUser.Username && u.Password == loginUser.Password);
                if (user == null)
                    throw new Exception("Invalid username or password");
                return user;
            }
            catch (Exception e)
            {

                Console.WriteLine(e.Message);
                return null;
            }

        }

    }
}
