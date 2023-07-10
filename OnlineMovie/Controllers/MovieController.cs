using OnlineMovie.Models;
using OnlineMovie.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineMovie.Controllers
{
    public static class MovieController
    {
        public static void Index()
        {
            var movies = Context.Movies;

            MovieViews.Index(movies);
        }
        public static void Add()
        {
            var movie = MovieViews.Add();

            Context.Movies.Add(movie);
        }
        public static void Search(string name)
        {
            var movies = Context.Movies.Where(m => m.Title.ToLower().Contains(name.ToLower())).ToList();
            MovieViews.Index(movies);
        }
    }
}
