namespace OnlineMovie.Models
{
    public class ShowSeat : HallSeat
    {
        public int Id { get; set; }
        public int Number { get; set; }
        public bool IsReserved { get; set; }
        public decimal Price { get; set; }
        public Show Show { get; set; }
    }
}
