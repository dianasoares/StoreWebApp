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

        public DbSet<WebStoreApplication.Models.Department> Department { get; set; }
    }
}
