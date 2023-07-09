namespace OnlineMovie.Models
{
    public class Ticket
    {
        public int Id { get; set; }
        public Customer Customer { get; set; }
        public ShowSeat ShowSeat { get; set; }
        public DateTime CreatedOn { get; set; }
    }
}
