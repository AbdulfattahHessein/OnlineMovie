using OnlineMovie.Controllers;
using OnlineMovie.Models;
using OnlineMovie.Views;

namespace OnlineMovie
{
    public class Program
    {
        static void Main(string[] args)
        {
            //This code for test only
            Console.WriteLine("Click 1 for showing all movies");
            Console.WriteLine("Click 2 to search");

            var input = int.Parse(Console.ReadLine());
            switch (input)
            {
                case 1:
                    MovieController.Index();
                    break;
                case 2:
                    Console.Clear();
                    Console.Write("Enter movie name: ");
                    var name = Console.ReadLine();
                    MovieController.Search(name);
                    break;
            }
        }
    }
}