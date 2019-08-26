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
    public class ConvertAmountsController : Controller
    {
        public ApplicationDbContext _context;

        public ConvertAmountsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: ConvertAmounts
        public async Task<IActionResult> Index()
        {
            var client = new RestClient("https://spoonacular-recipe-food-nutrition-v1.p.rapidapi.com/recipes/convert?sourceUnit=cups&sourceAmount=2.5&ingredientName=flour&targetUnit=grams");
            var request = new RestRequest(Method.GET);
            request.AddHeader("x-rapidapi-host", "spoonacular-recipe-food-nutrition-v1.p.rapidapi.com");
            request.AddHeader("x-rapidapi-key", "f2216af4f5msh71430f2e651f9dap1350a2jsn801bc5c5aa5f");
            IRestResponse response = client.Execute(request);
            var data = response.Content;
            ConvertAmounts jsonResults = JsonConvert.DeserializeObject<ConvertAmounts>(data);
            return View(await _context.ConvertAmounts.ToListAsync());
        }

        // GET: ConvertAmounts/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var convertAmounts = await _context.ConvertAmounts
                .FirstOrDefaultAsync(m => m.type == id);
            if (convertAmounts == null)
            {
                return NotFound();
            }

            return View(convertAmounts);
        }

        // GET: ConvertAmounts/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: ConvertAmounts/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("type,sourceAmount,sourceUnit,targetAmount,targetUnit,answer")] ConvertAmounts convertAmounts)
        {
            if (ModelState.IsValid)
            {
                _context.Add(convertAmounts);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(convertAmounts);
        }

        // GET: ConvertAmounts/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var convertAmounts = await _context.ConvertAmounts.FindAsync(id);
            if (convertAmounts == null)
            {
                return NotFound();
            }
            return View(convertAmounts);
        }

        // POST: ConvertAmounts/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("type,sourceAmount,sourceUnit,targetAmount,targetUnit,answer")] ConvertAmounts convertAmounts)
        {
            if (id != convertAmounts.type)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(convertAmounts);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ConvertAmountsExists(convertAmounts.type))
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
            return View(convertAmounts);
        }

        // GET: ConvertAmounts/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var convertAmounts = await _context.ConvertAmounts
                .FirstOrDefaultAsync(m => m.type == id);
            if (convertAmounts == null)
            {
                return NotFound();
            }

            return View(convertAmounts);
        }

        // POST: ConvertAmounts/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            var convertAmounts = await _context.ConvertAmounts.FindAsync(id);
            _context.ConvertAmounts.Remove(convertAmounts);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ConvertAmountsExists(string id)
        {
            return _context.ConvertAmounts.Any(e => e.type == id);
        }
    }
}
