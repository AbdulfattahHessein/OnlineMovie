using OnlineMovie.Controllers;
using OnlineMovie.Models;
using OnlineMovie.Views;
using System.Threading.Channels;
using static System.Console;

namespace OnlineMovie
{
    public class Program
    {
        static void Main(string[] args)
        {
            do
            {
                WriteLine("[1] Login           [2] Registration");
                Write("Select your option: ");
                var option = int.Parse(ReadLine());
                switch (option)
                {
                    case 1: AccountController.Login(); break;

                    case 2: AccountController.Registration(); break;
                }
                Write("Do you want to colse the program y / n :");
            } while (ReadLine() == "n");

        }
    }
}