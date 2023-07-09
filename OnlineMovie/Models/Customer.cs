namespace OnlineMovie.Models
{
    public class Customer : Person
    {
        public List<Ticket> Tickets { get; set; }
        //public bool MakeBooking()
        //{
        //    //check if there are tickits or not for movie you want
        //}

    }
}
