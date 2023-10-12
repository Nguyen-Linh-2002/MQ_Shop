using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MQ_Shop.Data.Data
{
   public class Products
    {
        public int id { get; set; }
        public double price { get; set; }
        public int stock { get; set; }
        public int viewcount { get; set; }
        public string seoAlias { get; set; }
        public DateTime datecreate  { get; set; }
        public bool? IsFeatured { get; set; }
        public Category category { get; set; }
        public ICollection<OrderDetail> orderDetails { get; set; }
        public ICollection<producttransaction> producttransactions { get; set; }
        public ICollection<Cart> carts { get; set; }
        public ICollection<ProductImg> productImgs { get; set; }
    }
}
