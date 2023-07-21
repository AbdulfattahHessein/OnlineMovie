namespace OnlineMovie.Models
{
    public class Hall
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Rows { get; set; }
        public int Columns { get; set; }
        public int TotalSeats { get; set; }
        public List<Show> Shows { get; set; }
        public List<HallSeat> HallSeats { get; set; }

    }
}
