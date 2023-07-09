using OnlineMovie.Enums;

namespace OnlineMovie.Models
{
    public class Account
    {
        public int Id { get; set; }
        public string username { get; set; }
        public string Password { get; set; }
        public AccountStatus AccountStatus { get; set; }
    }
}
