using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GroceryStoreRewards.Models
{
    public static class ModelBuilderExtensions
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
          

            modelBuilder.Entity<Recipes>().HasData(
                      new Recipes
                      {
                          Id = 1,
                          ingredientAmounts = 2,
                          ingredients = "pasta", 
                      }
                      );
            modelBuilder.Entity<Recipes>().HasData(
                      new Recipes
                      {
                          Id = 2,
                          ingredientAmounts = 2,
                          ingredients = "chicken"
                      }
                      );
            modelBuilder.Entity<Recipes>().HasData(
                     new Recipes
                     {
                         Id = 3,
                         ingredientAmounts = 4,
                         ingredients = "chickenBreast"
                     }
                     );
            modelBuilder.Entity<Recipes>().HasData(
                     new Recipes
                     {
                         Id = 4,
                         ingredientAmounts = 3,
                         ingredients = "leanChicken"
                     }
                     );
            modelBuilder.Entity<Recipes>().HasData(
                     new Recipes
                     {
                         Id = 5,
                         ingredientAmounts = 10,
                         ingredients = "ChickenBroth"
                     }
                     );
            modelBuilder.Entity<Recipes>().HasData(
                    new Recipes
                    {
                        Id = 6,
                        ingredientAmounts = 20,
                        ingredients = "CondensedChicken"
                    }
                    );
            modelBuilder.Entity<Recipes>().HasData(
                    new Recipes
                    {
                        Id = 7,
                        ingredientAmounts = 5,
                        ingredients = "chickenSoup"
                    }
                    );
            modelBuilder.Entity<Recipes>().HasData(
                    new Recipes
                    {
                        Id = 8,
                        ingredientAmounts = 4,
                        ingredients = "breadedChicken"
                    }
                    );
        }
    }
}
