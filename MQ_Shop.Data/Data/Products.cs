using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MQ_Shop.Data.Data
{
   public class Products
    {
        public Guid id { get; set; }
        public decimal price { get; set; }
        public int stock { get; set; }
        public int viewcount { get; set; }
        public string seoAlias { get; set; }
        public DateTime datecreate  { get; set; }
    }
}
