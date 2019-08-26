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
        [Key]
        public int Id { get; set; }
        public double ingredientAmounts { get; set; }
        public string ingredients { get; set; }
        
        public string instructions { get; set; }
        
        public string Name { get; set; }

        [ForeignKey("Customer")]
        public Customer customer { get; set; }

         public ICollection<CustomerRecipes> customerRecipes { get; set; }



    }   }
