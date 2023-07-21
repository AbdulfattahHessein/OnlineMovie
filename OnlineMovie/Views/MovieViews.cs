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
        public static Movie EditDetails(Movie movie)
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

        public static Show EditShows(Show show)
        {
            Console.Write($"{nameof(show.StartTime)} : ");
            show.StartTime = DateTime.Parse(ReadLine());

            Console.Write($"{nameof(show.EndTime)} : ");
            show.EndTime = DateTime.Parse(ReadLine());

            Console.Write($"{nameof(show.Hall)} : ");
            show.Hall.Name = Console.ReadLine();

            return show;
        }
    }
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








        //        if (!string.IsNullOrEmpty(startTime))
        //        {
        //            show.StartTime = DateTime.Parse(startTime);
        //        }
        //        else
        //        {
        //            Console.WriteLine("Invalid start time.");
        //        }



        //        if (!string.IsNullOrEmpty(endTime))
        //        {
        //            show.EndTime = DateTime.Parse(endTime);
        //        }
        //        else
        //        {
        //            Console.WriteLine("Invalid End time.");
        //        }

        //        if (!string.IsNullOrEmpty(hallName))
        //        {
        //            var _hall = Context.Halls.Find(h => h.Name == hallName);

        //            if (_hall == null)
        //            {
        //                Console.WriteLine("Invalid hall name.");
        //                return movie;
        //            }

        //            else
        //            {
        //                show.Hall = _hall;
        //            }
        //        }
        //    }


        //    return editMovie;

        //}


   
