using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client;
using ShopApp.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopApp.Dal.Concrete.EfCore
{
    public class ShopContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=MANGTAY\SQLDERS; Database=ShopApp; Integrated Security = true;
            TrustServerCertificate = true");


        }
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }


    }
}
