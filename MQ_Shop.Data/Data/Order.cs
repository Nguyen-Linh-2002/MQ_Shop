using MQ_Shop.Data.enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MQ_Shop.Data.Data
{
   public class Order
    {
      public int  id { get; set; }
      public DateTime orderdate { get; set; }
      public Guid userid { get; set; }
      public string shipName { get; set; }
      public string Email { get; set; }
      public string shipAddress { get; set; }
      public string shipPhone { get; set; } 
      public OrderStatus Status { get; set; }
        public ICollection<OrderDetail> orderDetails { get; set; }
        public User User { get; set; }
    }
}
