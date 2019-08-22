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

>>>>>>> 158a5fa2b82d2e0edbadef26732d61bd62cb003e
        public DbSet<ShoppingList> ShoppingLists { get; set; }

        public DbSet<Recipes> Recipes { get; set; }
<<<<<<< HEAD



        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
       
        modelBuilder.Entity<ShoppingList>().HasData(
                  new ShoppingList
                  {
                      UserId = 1,
                      FirstName = "mary",
                      Ingredients = "Oats"
                  }
                  );
            }

        }
    }

=======
    }
}
>>>>>>> 247495e1db156096fffc91567cc247580b3244ab

    


