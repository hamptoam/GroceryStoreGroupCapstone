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
        public DbSet<Customer> Customer { get; set; }
        public DbSet<ShoppingList> ShoppingLists { get; set; }
       



=======
>>>>>>> da6537fc5b46cfc1f9d8324d191149831ddf8724
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {

        }
<<<<<<< HEAD
        

          
=======

        public DbSet<Customer> Customer { get; set; }
        public DbSet<Recipes> Recipes { get; set; }



>>>>>>> da6537fc5b46cfc1f9d8324d191149831ddf8724
    }


}

