using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace GroceryStoreRewards.Models
{
    public class ShoppingList
    {
        [Key]
        [Display(Name = "user id")]
        public int UserId { get; set; }

        [Display(Name = "First Name")]
        public string FirstName { get; set; }

       

    }
}
