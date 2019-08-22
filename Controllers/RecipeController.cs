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
    [Route("api/[controller]")]
    [ApiController]
    public class RecipeController : ControllerBase
    {
        ApplicationDbContext db;
        // GET: api/Recipe
        [HttpGet]
        public IEnumerable<Recipes> Get()
        {
             var Recipes = db.Recipes.ToList();
            return Recipes;
        }

        // GET: api/Recipe/5
        [HttpGet("{id}", Name = "Get")]
        public Recipes Get(int id)
        {
            var Recipes = db.Recipes.Where(s => s.Id == id).SingleOrDefault();
            return Recipes;
        }

        // POST: api/Recipe
        [HttpPost]
        public void Post([FromBody] Recipes recipes)
        {
            db.Recipes.Add(recipes);
            db.SaveChanges();
        }

        // PUT: api/Recipe/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Recipes recipes)
        {
            Recipes recipes1 = db.Recipes.FirstOrDefault(s => s.Id == id);
            recipes1.Id = recipes.Id;
            recipes1.ingredientAmounts = recipes.ingredientAmounts;
            recipes1.ingredients = recipes.ingredients;

            db.SaveChanges();
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            db.Recipes.Remove(db.Recipes.FirstOrDefault(s => s.Id == id));
            db.SaveChanges();
        }
    }
}
