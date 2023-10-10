using MQ_Shop.Data.enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MQ_Shop.Data.Data
{
   public class Category
    {
       public Guid id { get; set; }
       public int sortoder { get; set; }
       public bool isshowonhome { get; set; }
        public int? parentId { get; set; }
        public status Status { get; set; }

    }
}
