﻿using DutchTreat.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DutchTreat.Data
{
    public class DutchContext : Microsoft.EntityFrameworkCore.DbContext
    {
        public DutchContext(DbContextOptions<DutchContext> options) : base(options)
        {
        }
        public Microsoft.EntityFrameworkCore.DbSet<Product> Products { get; set; }
        public Microsoft.EntityFrameworkCore.DbSet<Order> Orders { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            base.OnModelCreating(modelBuilder);
            
            modelBuilder.Entity<Order>()
               .HasData(new Order()
               {
                   Id = 1,
                   OrderDate = DateTime.UtcNow,
                   OrderNumber = "12345"
               });
        }
    }
}
