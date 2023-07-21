using OnlineMovie.Models;
using OnlineMovie.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineMovie.Controllers
{
    public static class TicketController
    {
        public static Ticket CreateTicket(int id)
        {
            var movie = Context.Movies.Find(m => m.Id == id);
            var createdTicket = TicketViews.CreateTicket(movie);
        }
    }
}
