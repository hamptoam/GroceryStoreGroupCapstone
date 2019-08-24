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
        public ApplicationDbContext()
        {
        }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        { }
        public DbSet<Customer> Customer { get; set; }

        public DbSet<ShoppingList> ShoppingLists { get; set; }

        public DbSet<Recipes> Recipes { get; set; }

        public DbSet<Ingredients> Ingredients{ get; set; }

<<<<<<< HEAD
        public DbSet<GroceryStoreRewards.Models.SummarizeRecipeAPI> SummarizeRecipeAPI { get; set; }
=======
        public DbSet<SummarizeRecipeAPI> SummarizeRecipeAPI { get; set; }

        public DbSet<RecipeIngredient> RecipeIngredient { get; set; }

        public DbSet<ConvertAmounts> ConvertAmounts { get; set; }

        public DbSet<Likes> customerLikes { get; set; }

        public DbSet<Likes> Likes { get; set; }

>>>>>>> 05d98a4bcc83453df2d947ff00c4f1beb91ae19e


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Seed();
        }



<<<<<<< HEAD
       

=======
    
>>>>>>> 05d98a4bcc83453df2d947ff00c4f1beb91ae19e



   

    
}   }

