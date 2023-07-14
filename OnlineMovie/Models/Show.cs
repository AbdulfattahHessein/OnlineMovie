namespace OnlineMovie.Models
{
    public class Show : IEntity
    {
        private static int _count = 1;
        public int Id { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public Movie Movie { get; set; }
        public Hall Hall { get; set; }
        public List<ShowSeat> ShowSeats { get; set; }

        public void Save()
        {
            Id = _count++;
        }
    }
}
