using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace GroceryStoreRewards.Models
{
    public class Admin
    {
        [Key]
        [Display(Name = "user id")]
        public string UserId { get; set; }

    }
}
