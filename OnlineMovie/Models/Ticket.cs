using OnlineMovie.Enums;

namespace OnlineMovie.Models
{
    public class Ticket
    {
        private static int _count = 1;
        public int Id { get; set; } 
        public Customer Customer { get; set; }
        public Show Show { get; set; }
        public ShowSeat ShowSeat { get; set; }
        public DateTime CreatedOn { get; set; }
        public BookingStatus Status { get; set; }
        public double Price { get; set; }

        public void Save()
        {
            Id = _count++;
        }

        public Ticket()
        {
            CreatedOn = DateTime.Now;
            Status = BookingStatus.Requested;
            Price = 0;
        }
    }
}
