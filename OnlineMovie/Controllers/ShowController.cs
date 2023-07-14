using OnlineMovie.Models;
using OnlineMovie.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineMovie.Controllers
{
    public class ShowController
    {
        public static Dictionary<int, Show> Index()
        {
            var shows = Context.Shows;
            ShowViews.Index(shows);
            Dictionary<int, Show> showsDictionary = new Dictionary<int, Show>();
            for (int i = 0; i < shows.Count; i++)
            {
                showsDictionary.Add(i + 1, shows[i]);
            }
            return showsDictionary;

        }
        public static void AddToMovie(int movieId)
        {
            var movie = Context.Movies.FirstOrDefault(m => m.Id == movieId);
            if (movie == null)
            {
                Console.WriteLine("movie not found");
            }
            movie.Shows.Save(ShowViews.Add());

        }
    }
}
