using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineMovie.Models
{
    public class User
    {
        private static int _count = 1;
        public int Id { get; private set; } = _count++;
        public string Name { get; set; }
        public Address Address { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public Account Account { get; set; }
        public User()
        {
            Account = new Account();
        }

    }
}
