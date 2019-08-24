using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace GroceryStoreRewards.Models
{
    public class Customer
    { 
        [Key]
        [Display(Name = "user id")]
        public string UserId { get; set; }

        [Display(Name = "First Name")]
        public string FirstName { get; set; }

        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        public string Email { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]


        public string Preference { get; set; }

        [ForeignKey("Ingredients")]
        public Ingredients ingredients { get; set; }

        public ICollection<CustomerRecipes>customerRecipes { get; set; }


    }
}
