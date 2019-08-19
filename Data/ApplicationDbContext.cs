using System;
using System.Collections.Generic;
using System.Text;
using GroceryStoreRewards.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace GroceryStoreRewards.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
      
<<<<<<< HEAD

=======
>>>>>>> 537cf268f20828073686b06ddcae9bf0fa593b1d
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {

        }
        
<<<<<<< HEAD
            public DbSet <Customer> Customer { get; set; }
                     
            
=======
 
>>>>>>> 537cf268f20828073686b06ddcae9bf0fa593b1d
        
    }
}

