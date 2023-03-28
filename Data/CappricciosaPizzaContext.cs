using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapricciosaPizza.Models;
using Microsoft.EntityFrameworkCore;

namespace CapricciosaPizza.Data
{
    public class CappricciosaPizzaContext : DbContext
    {
        public DbSet<Customer> Customers { get; set; } = null!;

        public DbSet<Order> Orders { get; set; } = null!;

        public DbSet<Product> Products { get; set; } = null!;

        public DbSet<OrderDetail> OrderDetails { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\ProjectModels;database=CappricciosaPizza;Encrypt=False;TrustServerCertificate=False;Trusted_Connection=true;");
        }
    }
}
