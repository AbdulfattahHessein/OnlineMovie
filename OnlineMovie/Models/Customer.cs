namespace OnlineMovie.Models
{
    public class Customer : User
    {
        public List<Ticket> Tickets { get; set; }
    }
}
