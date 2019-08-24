using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace GroceryStoreRewards.Models
{
    public class Ingredients
    {
        [Key]
        public int Id { get; set; }

        public string name { get; set; }

        
       public Customer Customer { get; set; }


    }
}
