using OnlineMovie.Controllers;
using OnlineMovie.Enums;
using OnlineMovie.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineMovie.Views
{
    public static class TicketViews
    {
        public static Ticket CreateTicket(Movie movie)
        {
            Ticket tempTicket = new Ticket();
            Console.WriteLine("select a show::");
            ShowViews.Index(movie.Shows);


            Console.Write("Enter the number of the show you want to book: ");
            var showId = int.Parse(Console.ReadLine());
            var selectedShow = movie.Shows.Find(s => s.Id == showId);


            Console.WriteLine("Please select the seat you want to book from the available seats:");
            int rows = selectedShow.Hall.Rows;
            int columns = selectedShow.Hall.Columns;
            for (int i = 1; i <= rows; i++)
            {
                for (int j = 1; j <= columns; j++)
                {
                    var _seat = selectedShow.ShowSeats.Find(s => s.RowNumber == i && s.ColumnNumber == j);

                    if (_seat.IsReserved)
                    {
                        Console.Write("[X] ");
                    }
                    else
                    {
                        Console.Write($"[{_seat.SeatNumber}] ");
                    }
                }
                Console.WriteLine();
            }


            Console.Write($"Enter the seat number for the seat you want to book: ");
            var seatNumber = int.Parse(Console.ReadLine());
            var selectedSeat = selectedShow.ShowSeats.Find(s => s.SeatNumber == seatNumber);


            tempTicket.Customer = null;
            tempTicket.Show = selectedShow;
            tempTicket.ShowSeat = selectedSeat;
            tempTicket.Price = selectedSeat.Price;

            return tempTicket;
        }

        public static void ShowTicketDetails(Ticket ticket)
        {
            Console.WriteLine($"ID: {ticket.Id}");
            Console.WriteLine($"Customer Name: {ticket.Customer.Name}");
            Console.WriteLine($"Movie Title: {ticket.Show.Movie.Title}");
            Console.WriteLine($"Show Time: {ticket.Show.StartTime} - {ticket.Show.EndTime}");
            Console.WriteLine($"Show Hall: {ticket.Show.Hall.Name}");
            Console.WriteLine($"Seat Numner: {ticket.ShowSeat.SeatNumber}");
            Console.WriteLine($"Price: {ticket.Price}");
            Console.WriteLine($"Ticket Status: {ticket.Status}");
            Console.WriteLine($"Created On: {ticket.CreatedOn.ToString()}");

        }

        public static bool CancelTicket(Ticket ticket)
        {
            if(ticket.Status == BookingStatus.Confirmed || ticket.Status == BookingStatus.CheckedIn || ticket.Status == BookingStatus.Canceled)
            {
                Console.WriteLine("Booking cannot be cancelled");
                return false;
            }

            else
            {
                ticket.ShowSeat.IsReserved = false;
                ticket.Status = BookingStatus.Canceled;
                Console.WriteLine("Ticket canceled.");
                return true;
            }
        }
    }
}
