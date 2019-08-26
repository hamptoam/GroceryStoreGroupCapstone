using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using GroceryStoreRewards.Data;
using GroceryStoreRewards.Models;
using Microsoft.AspNetCore.DataProtection.KeyManagement;
using RestSharp;
using Newtonsoft.Json;

namespace GroceryStoreRewards.Controllers
{
    public class RecipesController : Controller
    {
        public ApplicationDbContext _db;

        public RecipesController(ApplicationDbContext db)
        {
            Recipes recipe = new Recipes();
            _db = db;
        }

        // GET: Recipes
        public async Task<IActionResult> Index()
        {
           
            return View();
        }

        // GET: Recipes/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var recipes = await _db.Recipes
                .FirstOrDefaultAsync(m => m.Id == id);
            if (recipes == null)
            {
                return NotFound();
            }

            return View(recipes);
        }

        // GET: Recipes/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Recipes/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,ingredientAmounts,ingredients")] Recipes recipes)
        {
            var client = new RestClient("https://spoonacular-recipe-food-nutrition-v1.p.rapidapi.com/recipes/analyzeInstructions");
            var request = new RestRequest(Method.POST);
            request.AddHeader("x-rapidapi-host", "spoonacular-recipe-food-nutrition-v1.p.rapidapi.com");
            request.AddHeader("x-rapidapi-key", "f2216af4f5msh71430f2e651f9dap1350a2jsn801bc5c5aa5f");
            request.AddHeader("content-type", "application/x-www-form-urlencoded");
            request.AddParameter("application/x-www-form-urlencoded", "instructions=", ParameterType.RequestBody);
            IRestResponse response = client.Execute(request);
            var data = response.Content;
            Recipes jsonResults = JsonConvert.DeserializeObject<Recipes>(data);

            
                var recipe = new Recipes ();
                recipe.Name = recipes.Name;
                recipe.instructions = recipes.instructions;
                _db.Add(recipe);
                _db.SaveChanges();
            

            if (ModelState.IsValid)
            {
                
                _db.Add(recipes);
                await _db.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(recipes);
        }

        // GET: Recipes/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var recipes = await _db.Recipes.FindAsync(id);
            if (recipes == null)
            {
                return NotFound();
            }
            return View(recipes);
        }

        // POST: Recipes/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,ingredientAmounts,ingredients")] Recipes recipes)
        {

            var client = new RestClient("https://spoonacular-recipe-food-nutrition-v1.p.rapidapi.com/recipes/visualizeRecipe");
            var request = new RestRequest(Method.POST);
            request.AddHeader("x-rapidapi-host", "spoonacular-recipe-food-nutrition-v1.p.rapidapi.com");
            request.AddHeader("x-rapidapi-key", "f2216af4f5msh71430f2e651f9dap1350a2jsn801bc5c5aa5f");
            request.AddHeader("content-type", "multipart/form-data; boundary=---011000010111000001101001");
            IRestResponse response = client.Execute(request);

            var data = response.Content;
            CustomerRecipes jsonResults = JsonConvert.DeserializeObject<CustomerRecipes>(data);


            if (id != recipes.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _db.Update(recipes);
                    await _db.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!RecipesExists(recipes.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(recipes);
        }

        // GET: Recipes/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var recipes = await _db.Recipes
                .FirstOrDefaultAsync(m => m.Id == id);
            if (recipes == null)
            {
                return NotFound();
            }

            return View(recipes);
        }

        // POST: Recipes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var recipes = await _db.Recipes.FindAsync(id);
            _db.Recipes.Remove(recipes);
            await _db.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool RecipesExists(int id)
        {
            return _db.Recipes.Any(e => e.Id == id);
        }

        public object LikeOrDislike()
        {
            var customer = new Customer();
            var recipe = new Recipes();
          //  var customerRecipes = new CustomerRecipes(); make/find customerrecipes junction table 

            if (customer.customerLikes == true)
            {



            }

            else if (customer.customerLikes == false)
            {









            }

            return View();
        }
    }
}
