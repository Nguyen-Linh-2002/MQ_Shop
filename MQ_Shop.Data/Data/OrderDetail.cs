using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MQ_Shop.Data.Data
{
   public class OrderDetail
    {
      public int  orderid { get; set; }
      public int productid { get; set; }
      public int   quantily  { get; set; }
      public double price { get; set; }
        public Order order { get; set; }
        public Products products { get; set; }
    }
}
