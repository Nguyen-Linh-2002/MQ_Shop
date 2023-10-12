using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MQ_Shop.Data.Data
{
   public class User
    {
        public Guid Userid { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public DateTime DOB { get; set; }
        public string FullName { get; set; }
        public DateTime LastLoginDate { get; set; }
        public ICollection<Cart> carts { get; set; }
        public ICollection<Order> orders { get; set; }
        public ICollection<Transaction> transactions { get; set; }
    }
}
