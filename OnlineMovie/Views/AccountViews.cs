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
        public static Customer Registration()
        {
            var customer = new Customer();

            WriteLine("Enter your Information \n");

            Write("Name: ");
            customer.Name = ReadLine();

            Write("Username: ");
            customer.Username = ReadLine();

            Write("Password: ");
            customer.Password = ReadLine();

            return customer;
        }
        public static (string? Username, string? Password) Login()
        {
            Write("Username: ");
            var Username = ReadLine();

            Write("Password: ");
            var Password = ReadLine();

            return (Username, Password);
        }
    }
}
