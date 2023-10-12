using MQ_Shop.Data.enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MQ_Shop.Data.Data
{
   public  class Slide
    {
        public int id { get; set; }
        public string Name { set; get; }
        public string Description { set; get; }
        public string Url { set; get; }
        public string Image { get; set; }
        public int SortOrder { get; set; }
        public status Status { set; get; }
    }
}
