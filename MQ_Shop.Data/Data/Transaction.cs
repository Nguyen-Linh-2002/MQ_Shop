using MQ_Shop.Data.enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MQ_Shop.Data.Data
{
     public class Transaction
    {
       public int id { get; set; }
       public DateTime transactiondate { get; set; }
       public string externaltransactionID { get; set; }
        public decimal amount { get; set; }
        public decimal fee { get; set; }
        public TransactionStatus status{ get; set; }
        public string result { get; set; }
        public string Message { get; set; }
        public string provider { get; set; }
        public Guid UserId { get; set; }

        public User User { get; set; }
    }
}
