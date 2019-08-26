using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace GroceryStoreRewards.Models
{
    public class Recipes
    {
        public static object Ingredients { get; internal set; }
        [Key]
        public int Id { get; set; }
        public double ingredientAmounts { get; set; }
        public string ingredients { get; set; }

        [ForeignKey("Customer")]
        public Customer customer { get; set; }

         public ICollection<CustomerRecipes> customerRecipes { get; set; }



}   }
