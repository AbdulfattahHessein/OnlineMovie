using OnlineMovie.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace OnlineMovie.Views
{
    public static class AccountViews
    {
        public static User Registration()
        {
            WriteLine("Enter your Information \n");
            var user = new User();
            Write("Name: ");
            user.Name = ReadLine();

            Write("Username: ");
            user.Account.Username = ReadLine();

            Write("Password: ");
            user.Account.Password = ReadLine();

            return user;
        }
        public static Account Login()
        {
            Account account = new Account();

            Write("Username: ");
            account.Username = ReadLine();

            Write("Password: ");
            account.Password = ReadLine();

            return account;
        }
    }
}
