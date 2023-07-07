using OnlineMovie.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineMovie.Views
{
    public static class MovieViews
    {
        public static void Index(List<Movie> movies)
        {
            foreach (Movie movie in movies)
            {
                Console.WriteLine(movie);
            }
        }
    }
}
