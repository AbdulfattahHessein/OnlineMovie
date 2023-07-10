using OnlineMovie.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using static System.Console;

namespace OnlineMovie.Views
{
    public static class MovieViews
    {
        public static void Index(List<Movie> movies)
        {
            foreach (Movie movie in movies)
            {
                WriteLine(movie);
            }
        }
        public static Movie Add()
        {
            Movie movie = new();
            Write($"{nameof(movie.Title)}: ");
            movie.Title = ReadLine();

            Write($"{nameof(movie.Language)}: ");
            movie.Language = ReadLine();

            return movie;
        }

        public static void Remove(string title)
        {
            var movie = Context.Movies.Find(m => m.Title.ToLower().Contains(title.ToLower()));
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

        public static void Edit(string title, Movie editedMovie)
        {
            var oldMovie = Context.Movies.Find(m => m.Title.ToLower().Contains(title.ToLower()));

            if (oldMovie != null)
            {
                int temp = oldMovie.Id;
                oldMovie = editedMovie;
            }
        }

        public static void ShowMovieDetails(string title)
        {
            var movie = Context.Movies.Find(m => m.Title.ToLower().Contains(title.ToLower()));

            if (movie != null)
            {
                Console.WriteLine($"Id: {movie.Id}");
                Console.WriteLine($"Title: {movie.Title}");
                Console.WriteLine($"Description: {movie.Description}");
                Console.WriteLine($"DurationMins: {movie.DurationMins}");
                Console.WriteLine($"Language: {movie.Language}");
                Console.WriteLine($"Genre: {movie.Genre}");
                Console.WriteLine($"ReleaseDate: {movie.ReleaseDate.ToString()}");

                if (movie.Shows != null && movie.Shows.Count > 0)
                {
                    Console.WriteLine($"Shows: {movie.Shows.Count.ToString()}");
                    foreach (Show show in movie.Shows)
                    {
                        Console.WriteLine($"Show Number: {show.Id} | Start Time: {show.StartTime.ToString()}" +
                            $" | End Time: {show.EndTime.ToString()} | Show Hall: {show.Hall.Name}");
                    }
                }
                else
                {
                    Console.WriteLine("Shows: None");
                }
            }
            else
            {
                Console.WriteLine("Movie not found.");
            }
        }

        public static List<Show> GetShows(string title)
        {
            var movie = Context.Movies.Find(m => m.Title.ToLower().Contains(title.ToLower()));
            return movie.Shows;
        }
    }
}
