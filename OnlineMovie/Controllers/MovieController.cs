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
        public static Dictionary<int, Movie> Index()
        {
            var movies = Context.Movies;
            MovieViews.Index(movies);

            Dictionary<int, Movie> movieIndexToMovei = new Dictionary<int, Movie>();
            for (int i = 0; i < movies.Count; i++)
            {
                movieIndexToMovei.Add(i + 1, movies[i]);
            }
            return movieIndexToMovei;
        }
        public static void Add()
        {
            var movie = MovieViews.Add();


            Context.Movies.Save(movie);

            ShowController.AddToMovie(movie.Id);
        }
        public static void Details(int id)
        {
            var movie = Context.Movies.FirstOrDefault(m => m.Id == id);

            MovieViews.Details(movie);
        }
        public static void GetShows(int id)
        {
            var movie = Context.Movies.Find(m => m.Id == id);
            ShowViews.Index(movie.Shows);
        }
        public static void Search(string name)
        {
            var movies = Context.Movies.Where(m => m.Title.ToLower().Contains(name.ToLower())).ToList();

            MovieViews.Index(movies);
        }
        public static void Remove(int id)
        {
            var movie = Context.Movies.Find(m => m.Id == id);
            if (movie != null)
            {
                Context.Movies.Remove(movie);
            }
            else
                Console.WriteLine("Movie not found");
        }
        public static void Clear()
        {
            Context.Movies.Clear();
        }
        public static void EditDetails(int id)
        {

            var movie = Context.Movies.Find(m => m.Id == id);

            var editMovie = MovieViews.EditDetails(movie);

            if (!string.IsNullOrEmpty(editMovie.Title))
            {
                movie.Title = editMovie.Title;
            }

            if (!string.IsNullOrEmpty(editMovie.Genre))
            {
                movie.Genre = editMovie.Genre;
            }

            if (editMovie.DurationMins != 0)
            {
                movie.DurationMins = editMovie.DurationMins;

            }

            if (!string.IsNullOrEmpty(editMovie.ReleaseDate.ToString()))
            {
                movie.ReleaseDate = editMovie.ReleaseDate;
            }

            if (!string.IsNullOrEmpty(editMovie.Description))
            {
                movie.Description = editMovie.Description;
            }

            var index = Context.Movies.FindIndex(m => m.Id == movie.Id);

            Context.Movies[index] = movie;

            MovieViews.Details(movie);
        }
        public static void EditShows(int id)
        {
            var show = Context.Shows.Find(sh => sh.Id == id);
            var editShow = MovieViews.EditShows(show);


            if (!string.IsNullOrEmpty(editShow.StartTime.ToString()))
            {
                show.StartTime = editShow.StartTime;
            }
            else
            {
                Console.WriteLine("Invalid start time.");
            }


            if (!string.IsNullOrEmpty(editShow.EndTime.ToString()))
            {
                show.EndTime = editShow.EndTime;
            }
            else
            {
                Console.WriteLine("Invalid End time.");
            }

            if (!string.IsNullOrEmpty(editShow.Hall.Name))
            {
                var hall = Context.Halls.Find(h => h.Name == editShow.Hall.Name);

                if (hall == null)
                {
                    Console.WriteLine("Invalid hall name.");
                }

                else
                {
                    show.Hall = hall;
                }
            }

            var index = Context.Shows.FindIndex(sh => sh.Id == show.Id);

            Context.Shows[index] = show;

            ShowViews.Details(show);
        }
    }
}