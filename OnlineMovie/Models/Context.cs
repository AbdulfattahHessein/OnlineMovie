using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineMovie.Models
{
    public static class Context
    {
        public static List<Movie> Movies { get; set; } = new List<Movie>() {
            new Movie(){ Title = "Titanic", Description = "BLALALALLA", DurationMins = 120, Language = "English", Genre = "Romance", ReleaseDate = new DateOnly(2009, 3, 6), Shows = new List<Show>() {
                new Show() { Id = 1, StartTime = new DateTime(2022, 1, 1, 10, 0, 0), EndTime = new DateTime(2022, 1, 1, 12, 0, 0), Hall = new Hall() { Id = 1, Name = "Hall A"}, ShowSeats = new List<ShowSeat>() {
                    // Add show seats here
                }},
                new Show() { Id = 2, StartTime = new DateTime(2022, 1, 1, 14, 0, 0), EndTime = new DateTime(2022, 1, 1, 16, 0, 0), Hall = new Hall() { Id = 2, Name = "Hall B"}, ShowSeats = new List<ShowSeat>() {
                    // Add show seats here
                }}
            }},
            new Movie(){ Title = "Omar & Salma", Description = "BLALALALLA", DurationMins = 120, Language = "Arabic", Genre = "Romance", ReleaseDate = new DateOnly(2005, 6, 7), Shows = new List<Show>() {
                // Add shows here
            }},
            new Movie(){Title = "Tangled", Description = "BLALALALLA", DurationMins = 120, Language = "English", Genre = "Animation", ReleaseDate = new DateOnly(2010, 11, 5), Shows = new List<Show>() {
                // Add shows here
            }}

        };
        public static List<User> Users { get; set; } = new()
        {
            new Admin{Name = "Taha Hussein", Username = "admin", Password = "123"},
            new Customer{Name = "Isra ", Username = "israa", Password = "123"}
        };
        public static List<Hall> Halls { get; set; } = new();
        public static List<Show> Shows { get; set; } = new();

    }
}
