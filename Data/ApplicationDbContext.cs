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
        { }
        public DbSet<Customer> Customer { get; set; }

        public DbSet<ShoppingList> ShoppingLists { get; set; }

        public DbSet<Recipes> Recipes { get; set; }

        public DbSet<Ingredients> Ingredients{ get; set; }



        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Seed();
        }



    
}   }



    


