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
                var user = AccountViews.Registration();
                Context.Users.Add(user);
            }
            catch (Exception e)
            {

                Console.WriteLine(e.Message);
            }
        }
        public static void Login()
        {
            try
            {
                AccountViews.Login();
                Console.WriteLine("Login success");
            }
            catch (Exception e)
            {

                Console.WriteLine(e.Message);
            }

        }

    }
}
