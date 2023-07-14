using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineMovie.Models
{
    public abstract class User : IEntity
    {
        private static int _count = 1;
        public int Id { get; set; }
        public string Name { get; set; }
        public Address Address { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        //public Account Account { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }

        public void Save()
        {
            Id = _count++;
        }
    }
}
