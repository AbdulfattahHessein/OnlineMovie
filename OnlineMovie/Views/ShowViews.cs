using OnlineMovie.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineMovie.Views
{
    public static class ShowViews
    {
        public static void Index(List<Show> shows)
        {
            foreach (var show in shows)
            {
                Console.WriteLine($"Start Time: {show.StartTime}");
                Console.WriteLine($"End Time: {show.EndTime}");
                Console.WriteLine($"Hall: {show.Hall.Name}");
            }
        }

        public static void Details(Show show)
        {
            Console.WriteLine($"Start Time: {show.StartTime}");
            Console.WriteLine($"End Time: {show.EndTime}");
            Console.WriteLine($"Hall: {show.Hall.Name}");
        }

        public static Show Add()
        {

            Show show = new Show();
            Console.Write($"Start Time: ");
            show.StartTime = DateTime.Parse(Console.ReadLine());

            Console.Write($"End Time: ");
            show.EndTime = DateTime.Parse(Console.ReadLine());

            return show;

        }

    }
}
