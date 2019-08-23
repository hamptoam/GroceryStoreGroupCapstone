using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GroceryStoreRewards.Data;
using GroceryStoreRewards.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;


namespace GroceryStoreRewards.Controllers
{
    
    public class ShoppingListController : ControllerBase
    {
        ApplicationDbContext db;

       
      
        // GET: api/ShoppingList
        [HttpGet]
        public IEnumerable<ShoppingList> Get()
        {
          
            var shoppingList = db.ShoppingLists.ToList();
            return shoppingList;
        }

        // GET: api/ShoppingList/5
        [HttpGet("{id}", Name = "Get")]
        public ShoppingList Get(int id)  
        {
            var ShoppingList = db.ShoppingLists.Where(s => s.UserId == id).SingleOrDefault();
            return ShoppingList;
        }

        // POST: api/ShoppingList
        [HttpPost]
        public void Post([FromBody]ShoppingList ShoppingList)
        {
            db.ShoppingLists.Add(ShoppingList);
            db.SaveChanges();
        }

        // PUT: api/ShoppingList/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] ShoppingList shoppingList)
        {
            ShoppingList shoppingList1 = db.ShoppingLists.FirstOrDefault(s => s.UserId == id);
            shoppingList1.UserId = shoppingList.UserId;
            shoppingList1.FirstName = shoppingList.FirstName;

            db.SaveChanges();
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            db.ShoppingLists.Remove(db.ShoppingLists.FirstOrDefault(s => s.UserId == id));
            db.SaveChanges();
        }
    }
}
