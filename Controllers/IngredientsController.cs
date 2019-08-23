using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GroceryStoreRewards.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RestSharp;

namespace GroceryStoreRewards.Models
{
    
    public class IngredientsController : ControllerBase
    {
        ApplicationDbContext db;

        // GET: api/Ingredients
        [HttpGet]

        public IActionResult Index()
        {
            var client = new RestClient("https://spoonacular-recipe-food-nutrition-v1.p.rapidapi.com/recipes/1003464/ingredientWidget.json");
            var request = new RestRequest(Method.GET);
            request.AddHeader("x-rapidapi-host", "spoonacular-recipe-food-nutrition-v1.p.rapidapi.com");
            request.AddHeader("x-rapidapi-key", "9aea809182msh45b6cdf8b73c98fp19e9bajsnd317d98d96aa");
            IRestResponse response = client.Execute(request);
            return View(response);
        }

        private IActionResult View(IRestResponse response)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Ingredients> Get()
        {
            var Ingredients = db.Ingredients.ToList();
            return Ingredients;
        }

        // GET: api/Ingredients/5
        [HttpGet("{id}", Name = "Get")]
        public Ingredients Get(int id)
        {
            var Ingredients = db.Ingredients.Where(s => s.Id == id).SingleOrDefault();
            return Ingredients;
        }

        // POST: api/Ingredients
        [HttpPost]
        public void Post([FromBody] Ingredients ingredients)
        {
            db.Ingredients.Add(ingredients);
            db.SaveChanges();
        }

        // PUT: api/Ingredients/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Ingredients ingredients)
        {
           Ingredients ingredients1 = db.Ingredients.FirstOrDefault(s => s.Id == id);
            ingredients1.Id = ingredients.Id;
            ingredients1.Name = ingredients.Name;
            db.SaveChanges();
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            db.Ingredients.Remove(db.Ingredients.FirstOrDefault(s => s.Id == id));
            db.SaveChanges();
        }
    }
    
}
