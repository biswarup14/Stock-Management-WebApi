using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using FinalStockManage.Models;

namespace FinalStockManage.Data
{
    public class FinalStockManageContext : DbContext
    {
        public FinalStockManageContext (DbContextOptions<FinalStockManageContext> options)
            : base(options)
        {
        }

        public DbSet<CashOrder>? CashOrder { get; set; }

        public DbSet<ChargeOrder>? ChargeOrder { get; set; }

        public DbSet<Customer>? Customer { get; set; }

        public DbSet<Employee>? Employee { get; set; }

        public DbSet<Order>? Order { get; set; }

        public DbSet<Product>? Product { get; set; }

        public DbSet<Supplier>? Supplier { get; set; }

        public DbSet<User>? User { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>()
                 .HasIndex(x => x.Email)
                 .IsUnique();
        }
    }
}
