namespace OnlineMovie.Models
{
    public class ShowSeat : HallSeat
    {
        public int Id { get; set; }
        public int SeatNumber { get; set; }
        public bool IsReserved { get; set; }
        public double Price { get; set; }
        public Show Show { get; set; }
    }
}
