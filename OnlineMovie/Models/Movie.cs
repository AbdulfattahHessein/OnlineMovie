using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineMovie.Models
{
    public class Movie
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public int DurationMins { get; set; }
        public string Language { get; set; }
        public string Genre { get; set; }
        public DateTime ReleaseDate { get; set; }
        public List<Show> Shows { get; set; }


        public override string ToString()
        {
            return $"Title: {Title} | Description: {Description}";
        }
    }
}
