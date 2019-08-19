using System;
using System.Collections.Generic;
using System.Text;
using GroceryStoreRewards.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace GroceryStoreRewards.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        
            public DbSet <Customer> Customers { get; set; }
            public DbSet <GroceryStore> Stores { get; set; }            
            public DbSet <CustomerPurchases> Purchases { get; set; }
        
    }
}

