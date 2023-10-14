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
      public int  id { get; set; }
        public DateTime fromdate { get; set; }
        public DateTime todate { get; set; }
        public bool applyforall { get; set; }
       public double? discountpercent { get; set; }
        public double? discountamount { get; set; }
        public string productcategoryID { get; set; }
        public string productsid { get; set; }
        public string name { get; set; }
        public status status { get; set; }

    }
}
