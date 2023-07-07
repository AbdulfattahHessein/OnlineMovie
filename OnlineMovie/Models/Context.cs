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
            new Movie(){Title = "Titanic", Description = "BLALALALLA"},
            new Movie(){Title = "Omar & Salma", Description = "BLALALALLA"}
        };
    }
}
