using OnlineMovie.Enums;

namespace OnlineMovie.Models
{
    public class Account
    {
        private string _username;
        public string Username
        {
            get
            {
                return _username;
            }
            set
            {
                if (value == null)
                    throw new Exception("username can't be empty");
                if (Context.Users.FirstOrDefault() == null)
                    _username = value;
                else
                {
                    throw new Exception("This username is already taken");
                }
            }
        }
        public string Password { get; set; }
        public AccountStatus AccountStatus { get; set; }
        public Account()
        {
            AccountStatus = AccountStatus.Active;
        }
    }
}
