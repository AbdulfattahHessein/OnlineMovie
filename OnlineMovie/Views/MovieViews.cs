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
            for (int i = 0; i < movies.Count; i++)
            {
                WriteLine($"[{i + 1}] {movies[i].Title}");
            }
        }
        public static Movie Add()
        {
            Movie movie = new();

            Write($"{nameof(movie.Title)}: ");
            movie.Title = ReadLine();

            Write($"{nameof(movie.Description)}: ");
            movie.Description = ReadLine();

            Write($"{nameof(movie.DurationMins)}: ");
            movie.DurationMins = int.Parse(ReadLine());

            Write($"{nameof(movie.Genre)}: ");
            movie.Genre = ReadLine();


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

        public static void Details(Movie movie)
        {

            WriteLine($"Id: {movie.Id}");
            WriteLine($"Title: {movie.Title}");
            WriteLine($"Description: {movie.Description}");
            WriteLine($"DurationMins: {movie.DurationMins}");
            WriteLine($"Language: {movie.Language}");
            WriteLine($"Genre: {movie.Genre}");
            WriteLine($"ReleaseDate: {movie.ReleaseDate}");

            if (movie.Shows != null && movie.Shows.Count > 0)
            {
                Console.WriteLine($"Shows: {movie.Shows.Count}");
                foreach (Show show in movie.Shows)
                {
                    Console.WriteLine($"Show Number: {show.Id} | Start Time: {show.StartTime}" +
                        $" | End Time: {show.EndTime} | Show Hall: {show.Hall.Name}");
                }
            }
            else
            {
                Console.WriteLine("Shows: None");
            }

        }
        public static Movie Edit(Movie movie)
        {

            Details(movie);

            var editMovie = new Movie();

            Console.WriteLine("Enter the new movie details or leave them empty:");
            Console.Write($"{nameof(movie.Title)} : ");
            editMovie.Title = ReadLine();

            Console.Write($"{nameof(movie.Description)} : ");
            editMovie.Description = ReadLine();

            Console.Write($"{nameof(movie.DurationMins)} : ");
            if (String.IsNullOrEmpty(ReadLine()))
                editMovie.DurationMins = 0;

            Console.Write($"{nameof(movie.Language)} : ");
            editMovie.Language = ReadLine();

            Console.Write($"{nameof(movie.Genre)} : ");
            editMovie.Genre = ReadLine();

            Console.Write($"{nameof(movie.ReleaseDate)} (YYYY-MM-DD):");
            editMovie.ReleaseDate = DateOnly.Parse(ReadLine());

            return editMovie;

        }


    }
}
