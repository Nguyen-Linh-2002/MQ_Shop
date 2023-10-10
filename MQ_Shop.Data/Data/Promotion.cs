using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MQ_Shop.Data.enums;

namespace MQ_Shop.Data.Data
{
    public class Promotion
    {
      public Guid  id { get; set; }
        public DateTime fromdate { get; set; }
        public DateTime todate { get; set; }
        public bool applyforall { get; set; }
       public decimal? discountpercent { get; set; }
        public decimal? discountamount { get; set; }
        public Guid productcategoryID { get; set; }
        public Guid productsid { get; set; }
        public string name { get; set; }
        public status status { get; set; }

    }
}
