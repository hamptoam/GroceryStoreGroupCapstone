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
<<<<<<< HEAD

=======


<<<<<<< HEAD
=======
=======
>>>>>>> cb8bb93f1c2740859127868175941ddd92c50779
>>>>>>> f95223c0d82a40d8154da3543789a1803fabb5ae
>>>>>>> 5dfb8b7c81d2e4ee8ef36f5f355f4c4e00c9a85e
        public DbSet<ShoppingList> ShoppingLists { get; set; }

        public DbSet<Recipes> Recipes { get; set; }

        public DbSet<Ingredients> Ingredients{ get; set; }



        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Seed();
        }



    
}   }


<<<<<<< HEAD
=======
<<<<<<< HEAD
=======
=======
>>>>>>> cb8bb93f1c2740859127868175941ddd92c50779
>>>>>>> 5dfb8b7c81d2e4ee8ef36f5f355f4c4e00c9a85e

>>>>>>> f95223c0d82a40d8154da3543789a1803fabb5ae
    


