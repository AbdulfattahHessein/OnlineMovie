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
        public static List<Show> GetShows(string title)
        {
            var movie = Context.Movies.Find(m => m.Title.ToLower().Contains(title.ToLower()));
            return movie.Shows;
        }
        public static void Search(string name)
        {
            var movies = Context.Movies.Where(m => m.Title.ToLower().Contains(name.ToLower())).ToList();

            MovieViews.Index(movies);
        }
        public static void Edit(int id)
        {

            var movie = Context.Movies.Find(m => m.Id == id);

            var editMovie = MovieViews.Edit(movie);

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

            //Console.Write("Do you want to edit the shows for this movie? (y/n): ");

            //var option = Console.ReadLine();

            //if (option.ToLower() == "y")
            //{
            //    Console.WriteLine("The movie has the following shows:");
            //    foreach (var _show in movie.Shows)
            //    {
            //        Console.WriteLine(_show);
            //    }

            //    Console.Write("Enter the ID of the show you want to edit: ");
            //    var showId = int.Parse(ReadLine());
            //    var show = movie.Shows.Find(s => s.Id == showId);

            //    if (show == null)
            //    {
            //        Console.WriteLine("Invalid show ID.");
            //        return movie;
            //    }

            //    Console.Write($"{nameof(show.StartTime)} : ");
            //    var startTime = Console.ReadLine();

            //    Console.Write($"{nameof(show.EndTime)} : ");
            //    var endTime = Console.ReadLine();

            //    Console.Write($"{nameof(show.Hall)} : ");
            //    var hallName = Console.ReadLine();

            //    if (!string.IsNullOrEmpty(startTime))
            //    {
            //        show.StartTime = DateTime.Parse(startTime);
            //    }
            //    else
            //    {
            //        Console.WriteLine("Invalid start time.");
            //    }



            //    if (!string.IsNullOrEmpty(endTime))
            //    {
            //        show.EndTime = DateTime.Parse(endTime);
            //    }
            //    else
            //    {
            //        Console.WriteLine("Invalid End time.");
            //    }

            //    if (!string.IsNullOrEmpty(hallName))
            //    {
            //        var _hall = Context.Halls.Find(h => h.Name == hallName);

            //        if (_hall == null)
            //        {
            //            Console.WriteLine("Invalid hall name.");
            //            return movie;
            //        }

            //        else
            //        {
            //            show.Hall = _hall;
            //        }
            //    }
            //}

            //return movie;

        }
    }
}
