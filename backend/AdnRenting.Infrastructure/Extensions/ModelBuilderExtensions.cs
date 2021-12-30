using AdnRenting.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;

namespace AdnRenting.Infrastructure.Extensions
{
    public static class ModelBuilderExtensions
    {
        public static void SeedData(this ModelBuilder modelBuilder)
        {
            List<User> users = new List<User> {
                new User(){Id= Guid.NewGuid(), Country="Colombia", DateOfBirth=DateTime.Now.AddYears(-31), Email="test1@fmail.com", LastName="Ape", Name="Nom", Password="test1"},
                new User(){Id= Guid.NewGuid(), Country="Colombia", DateOfBirth=DateTime.Now.AddYears(-20), Email="test2@fmail.com", LastName="BotLn1", Name="BotNn1", Password="test1"},
                new User(){Id= Guid.NewGuid(), Country="Colombia", DateOfBirth=DateTime.Now.AddYears(-50), Email="test3@fmail.com", LastName="BotLn2", Name="BotNn2", Password="test1"},
            };

            modelBuilder.Entity<User>().HasData(users);
        }
    }
}
