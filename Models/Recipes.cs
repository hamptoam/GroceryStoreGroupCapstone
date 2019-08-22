using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace GroceryStoreRewards.Models
{
    public class Recipes
    {
        [Key]
        public int Id { get; set; }
        public double ingredientAmounts { get; set; }
        public string ingredients { get; set; }
        
    }
}
