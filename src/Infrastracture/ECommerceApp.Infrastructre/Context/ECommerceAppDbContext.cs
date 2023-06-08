﻿using ECommerceApp.Domain.Entities;
using ECommerceApp.Infrastructre.EntityTypeConfiguration;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerceApp.Infrastructre.Context
{
    public class ECommerceAppDbContext : DbContext
    {
        public ECommerceAppDbContext(DbContextOptions<ECommerceAppDbContext> options) : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new EmployeeConfig())
                        .ApplyConfiguration(new MallConfig());

            base.OnModelCreating(modelBuilder);
        }
        public DbSet<Mall> Malls { get; set; }
        public DbSet<Employee> Employees { get; set; }
    }
}
