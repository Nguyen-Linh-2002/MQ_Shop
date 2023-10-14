using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MQ_Shop.Data.Data
{
    public class MQ_ShopFactory : IDesignTimeDbContextFactory<MyDbContext>
    { 
        public MyDbContext CreateDbContext(string[] args)
        {
            IConfigurationRoot configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();
            var connect = configuration.GetConnectionString("MyDb");
            
                var optionsBuilder = new DbContextOptionsBuilder<MyDbContext>();
                optionsBuilder.UseSqlServer(connect);

                return new MyDbContext(optionsBuilder.Options);
        }
    }
}

