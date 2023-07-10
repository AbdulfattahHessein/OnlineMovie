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
        private static int _count = 1;
        public int Id { get; private set; }
        public string? Title { get; set; }
        public string? Description { get; set; }
        public int? DurationMins { get; set; }
        public string? Language { get; set; }
        public string? Genre { get; set; }
        public DateTime? ReleaseDate { get; set; }
        public List<Show>? Shows { get; set; }
        public Movie()
        {
            Id = _count++;

            Shows = new List<Show>();
        }
        /*
         Title: Omar
         Date: asduhasjkd

         Enter new information (leave it empty if you don't want to edit it )
         Title:
         Date: 25/6/8         
         */


        public override string ToString()
        {
            return $"[{Id}] Title: {Title}";
        }
    }
}
