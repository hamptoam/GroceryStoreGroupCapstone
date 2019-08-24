using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GroceryStoreRewards.Models
{
    public class CustomerRecipes
    {
        public int RecipeId { get; set; }
        public Recipes Recipes { get; set; }
        public string CustomerId { get; set; }
        public Customer customer { get; set; }
    }
}
