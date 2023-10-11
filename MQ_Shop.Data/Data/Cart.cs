using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MQ_Shop.Data.Data
{
     public class Cart
    {
        public int id { get; set; }
        public int productid { get; set; }
        public int quantily { get; set; }
        public decimal price { get; set; }
        public Guid UserId { get; set; }
        public DateTime DateCreated { get; set; }
        public Products Product { get; set; }
        public User AppUser { get; set; }
    }
}
