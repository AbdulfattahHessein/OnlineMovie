namespace OnlineMovie.Models
{
    public class Customer : Person
    {
        public List<Ticket> Tickets { get; set; }

    }
}
