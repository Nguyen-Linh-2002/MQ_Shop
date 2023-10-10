using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MQ_Shop.Data.Data
{
     public class Cart
    {
      public Guid id { get; set; }
      public Guid productid { get; set; }
      public int quantily { get; set; }
      public decimal price { get; set; }
    }
}
