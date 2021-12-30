using AdnRenting.Domain.Entities;
using AdnRenting.Infrastructure.Extensions;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace AdnRenting.Infrastructure.DataBase
{
    public class AdnDBContext : DbContext
    {
        public DbSet<Bill> Bills { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }
        public DbSet<User> Users { get; set; }

        public AdnDBContext(DbContextOptions<AdnDBContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            
            modelBuilder.SeedData();
            modelBuilder.Entity<Order>().HasOne(order => order.Bill).WithOne(bill => bill.Order).HasForeignKey<Bill>(bill => bill.OrderId);
        }
    }
}
