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

        public DbSet<Ingredients> Ingredients { get; set; }

<<<<<<< HEAD
       

=======
>>>>>>> e3ca22028eca5c933c4905717536d093dd080f84
        public DbSet<SummarizeRecipeAPI> SummarizeRecipeAPI { get; set; }

        public DbSet<RecipeIngredient> RecipeIngredient { get; set; }

        public DbSet<ConvertAmounts> ConvertAmounts { get; set; }

        public DbSet<Likes> customerLikes { get; set; }

        public DbSet<Likes> Likes { get; set; }

<<<<<<< HEAD
=======
        public DbSet<CustomerRecipes> customerRecipes { get; set; }
>>>>>>> e3ca22028eca5c933c4905717536d093dd080f84

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Seed();
        }

    }

<<<<<<< HEAD



        public DbSet<GroceryStoreRewards.Models.SearchRecipes> SearchRecipes { get; set; }




       


=======
<<<<<<< HEAD
>>>>>>> 835f06d89e74d89fc68617a5e513bfe65bbfd288



   

    
}   }
=======
}   
>>>>>>> e3ca22028eca5c933c4905717536d093dd080f84

