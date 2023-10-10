using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MQ_Shop.Data.Data
{
   public class MyDbContext:DbContext
    {
        public MyDbContext(DbContextOptions options): base(options) { }

    }
}
