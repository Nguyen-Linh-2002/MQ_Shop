using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MQ_Shop.Data.Data
{
   public class User
    {
        public Guid id { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public DateTime DOB { get; set; }
        public string FullName { get; set; }
        public DateTime LastLoginDate { get; set; }
    }
}
