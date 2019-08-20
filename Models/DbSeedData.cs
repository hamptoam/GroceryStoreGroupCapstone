using GroceryStoreRewards.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GroceryStoreRewards.Models
{
    public class DbSeedData
    {
        private ApplicationDbContext _context;

        public DbSeedData(ApplicationDbContext db)
        {
            _context = db;
        }


        public void EnsureSeedData()
        {
            if (!_context.ShoppingLists.Any())
            {
                {
                    _context.ShoppingLists.Add(
                       new ShoppingList { FirstName = "" }
                     );
                       
                     
                        
                }
                    
                     
                    
            }
        }
    }
}
