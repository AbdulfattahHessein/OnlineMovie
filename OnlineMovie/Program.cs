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
                WriteLine("[1] Login \t\t [2] Registration");
                WriteLine("[3] Guest");
                Write("Select your option: ");
                var option = int.Parse(ReadLine());
                switch (option)
                {
                    case 1:
                        {
                            WriteLine("[1] Customer \t\t [2] Admin");
                            Write("Select your option: ");
                            var loginOption = int.Parse(ReadLine());
                            User user;
                            while ((user = AccountController.Login()) == null) ;
                            switch (loginOption)
                            {
                                case 1:
                                    {
                                        Customer customer = user as Customer;

                                        WriteLine($"Hello {customer?.Name}");
                                        WriteLine("[1] Show movies \t\t [2] My Tickets");
                                        Write("Select your option: ");
                                        //int.TryParse(ReadLine(), out int CustomerMainOption);
                                        switch (int.Parse(ReadLine()))
                                        {
                                            case 1:
                                                {
                                                    var moviesDictionary = MovieController.Index();
                                                    Write("Select your option: ");
                                                    var movie = moviesDictionary[int.Parse(ReadLine())];
                                                    WriteLine("[1] Movie's Details \t\t [2] Movie's Shows");
                                                    WriteLine("[3] Buy Ticket");
                                                    Write("Select your option: ");


                                                    switch (int.Parse(ReadLine()))
                                                    {
                                                        case 1:
                                                            {
                                                                MovieController.Details(movie.Id);

                                                            }
                                                            break;
                                                        default:
                                                            break;
                                                    }




                                                }
                                                break;
                                            default:
                                                break;
                                        }

                                    }
                                    break;
                                case 2:
                                    {
                                        Admin? customer = user as Admin;

                                        WriteLine($"Hello {customer?.Name}");
                                        WriteLine("[1] Add movie \t\t [2] Add Show");
                                        WriteLine("[3] Edit Movie \t\t [4] Cancel Show");
                                        Write("Select your option: ");
                                        switch (int.Parse(ReadLine()))
                                        {
                                            case 1:
                                                {
                                                    MovieController.Add();
                                                }
                                                break;
                                            case 2:
                                                {

                                                }
                                                break;
                                            case 3:
                                                {
                                                    var indexToMovie = MovieController.Index();
                                                    Write("Select movie you want to edit: ");
                                                    var movie = indexToMovie[int.Parse(ReadLine())];
                                                    MovieController.Edit(movie.Id);
                                                }
                                                break;
                                            default:
                                                break;
                                        }
                                    }
                                    break;
                                default:
                                    break;
                            }


                        }
                        break;

                    case 2: AccountController.Registration(); break;
                }
                Write("Do you want to colse the program y / n :");
            } while (ReadLine() == "n");

        }
    }
}