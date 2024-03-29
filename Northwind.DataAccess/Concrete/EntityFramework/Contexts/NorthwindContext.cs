﻿using Microsoft.EntityFrameworkCore;
using Northwind.Core.Entities.Concrete;
using Northwind.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Northwind.DataAccess.Concrete.EntityFramework.Contexts
{
    public class NorthwindContext : DbContext 
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(connectionString: @"Server=EMRESARIDOGAN\SQLEXPRESS;Database=Northwind;Trusted_Connection=true");
            //base.OnConfiguring(optionsBuilder);
        }

        

        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<OperationClaim> OperationClaims { get; set; }
        public DbSet<UserOperationClaim> UserOperationClaims { get; set; }

    }
}
