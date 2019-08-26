using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace GroceryStoreRewards.Models
{
    public class CustomerRecipes
    {

        [Key]
        public int RecipeId { get; set; }
        public Recipes Recipes { get; set; }
        public string CustomerId { get; set; }
        public Customer customer { get; set; }
    }
}
