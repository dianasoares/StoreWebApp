using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WebStoreApplication.Models;

namespace WebStoreApplication.Data
{
    public class WebStoreApplicationContext : DbContext
    {
        public WebStoreApplicationContext (DbContextOptions<WebStoreApplicationContext> options)
            : base(options)
        {
        }

        public DbSet<Department> Department { get; set; }
        public DbSet<Seller> Seller { get; set; }
        public DbSet<SalesRecord> salesRecord { get; set; }
    }
}
