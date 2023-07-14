using OnlineMovie.Enums;

namespace OnlineMovie.Models
{
    public class Account
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public AccountStatus AccountStatus { get; set; }
        public Account()
        {
            AccountStatus = AccountStatus.Active;
        }
        public override bool Equals(object obj)
        {
            if (ReferenceEquals(this, obj))
                return true;

            if (obj == null || GetType() != obj.GetType())
                return false;

            Account other = (Account)obj;
            return Username == other.Username && Password == other.Password;
        }
        public static bool operator ==(Account? left, Account? right)
        {
            if (ReferenceEquals(left, right))
                return true;
            if (ReferenceEquals(left, null))
                return false;
            if (ReferenceEquals(right, null))
                return false;

            return left.Equals(right);
        }
        public static bool operator !=(Account left, Account right) => !(left == right);
    }
}
