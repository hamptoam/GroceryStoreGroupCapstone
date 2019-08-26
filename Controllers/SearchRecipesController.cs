using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using GroceryStoreRewards.Data;
using GroceryStoreRewards.Models;
using RestSharp;
using Newtonsoft.Json;

namespace GroceryStoreRewards.Controllers
{
    public class SearchRecipesController : Controller
    {
        private readonly ApplicationDbContext _context;

        public SearchRecipesController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: SearchRecipes
        public async Task<IActionResult> Index()
        {
            var client = new RestClient("https://spoonacular-recipe-food-nutrition-v1.p.rapidapi.com/recipes/search?diet=vegetarian&excludeIngredients=coconut&intolerances=egg%2C%20gluten&number=10&offset=0&type=main%20course&query=burger");
            var request = new RestRequest(Method.GET);
            request.AddHeader("x-rapidapi-host", "spoonacular-recipe-food-nutrition-v1.p.rapidapi.com");
            request.AddHeader("x-rapidapi-key", "f2216af4f5msh71430f2e651f9dap1350a2jsn801bc5c5aa5f");
            IRestResponse response = client.Execute(request);
            var data = response.Content;
            SearchRecipes jsonResults = JsonConvert.DeserializeObject<SearchRecipes>(data);
            return View(await _context.SearchRecipes.ToListAsync());
        }

        // GET: SearchRecipes/Details/5
        public async Task<IActionResult> Details(int? id)
        {

            var client = new RestClient("https://spoonacular-recipe-food-nutrition-v1.p.rapidapi.com/recipes/findByIngredients?number=5&ranking=1&ignorePantry=false&ingredients=apples%2Cflour%2Csugar");
            var request = new RestRequest(Method.GET);
            request.AddHeader("x-rapidapi-host", "spoonacular-recipe-food-nutrition-v1.p.rapidapi.com");
            request.AddHeader("x-rapidapi-key", "f2216af4f5msh71430f2e651f9dap1350a2jsn801bc5c5aa5f");
            IRestResponse response = client.Execute(request);
            var data = response.Content;
            SearchRecipes jsonResults = JsonConvert.DeserializeObject<SearchRecipes>(data);
            return View(await _context.SearchRecipes.ToListAsync());


            if (id == null)
            {
                return NotFound();
            }

            var searchRecipes = await _context.SearchRecipes
                .FirstOrDefaultAsync(m => m.id == id);
            if (searchRecipes == null)
            {
                return NotFound();
            }

            return View(searchRecipes);
        }

        // GET: SearchRecipes/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: SearchRecipes/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("id,MyProperty,results,baseUri,offset,number,totalRequests,processingTimeMs,expires,isStale")] SearchRecipes searchRecipes)
        {
            if (ModelState.IsValid)
            {
                _context.Add(searchRecipes);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(searchRecipes);
        }

        // GET: SearchRecipes/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var searchRecipes = await _context.SearchRecipes.FindAsync(id);
            if (searchRecipes == null)
            {
                return NotFound();
            }
            return View(searchRecipes);
        }

        // POST: SearchRecipes/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("id,MyProperty,results,baseUri,offset,number,totalRequests,processingTimeMs,expires,isStale")] SearchRecipes searchRecipes)
        {
            if (id != searchRecipes.id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(searchRecipes);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!SearchRecipesExists(searchRecipes.id))
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
            return View(searchRecipes);
        }

        // GET: SearchRecipes/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var searchRecipes = await _context.SearchRecipes
                .FirstOrDefaultAsync(m => m.id == id);
            if (searchRecipes == null)
            {
                return NotFound();
            }

            return View(searchRecipes);
        }

        // POST: SearchRecipes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var searchRecipes = await _context.SearchRecipes.FindAsync(id);
            _context.SearchRecipes.Remove(searchRecipes);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool SearchRecipesExists(int id)
        {
            return _context.SearchRecipes.Any(e => e.id == id);
        }
    }
}
