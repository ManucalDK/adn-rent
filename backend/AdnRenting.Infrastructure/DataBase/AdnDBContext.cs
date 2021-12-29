using AdnRenting.Domain.Entities;
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

            List<User> users = new List<User> {
                new User(){Country="Colombia", DateOfBirth=DateTime.Now.AddYears(-31), Email="test1@fmail.com", LastName="Ape", Name="Nom", Password="test1"},
                new User(){Country="Colombia", DateOfBirth=DateTime.Now.AddYears(-20), Email="test2@fmail.com", LastName="BotLn1", Name="BotNn1", Password="test1"},
                new User(){Country="Colombia", DateOfBirth=DateTime.Now.AddYears(-50), Email="test3@fmail.com", LastName="BotLn2", Name="BotNn2", Password="test1"},
            };

            modelBuilder.Entity<User>().HasData(users.ToArray());
        }
    }
}
