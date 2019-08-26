using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using GroceryStoreRewards.Data;
using GroceryStoreRewards.Models;

namespace GroceryStoreRewards.Controllers
{
    public class CustomerRecipesController : Controller
    {
        private readonly ApplicationDbContext _context;

        public CustomerRecipesController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: CustomerRecipes
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.customerRecipes.Include(c => c.Recipes).Include(c => c.customer);
            return View(await applicationDbContext.ToListAsync());
        }

        // GET: CustomerRecipes/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var customerRecipes = await _context.customerRecipes
                .Include(c => c.Recipes)
                .Include(c => c.customer)
                .FirstOrDefaultAsync(m => m.RecipeId == id);
            if (customerRecipes == null)
            {
                return NotFound();
            }

            return View(customerRecipes);
        }

        // GET: CustomerRecipes/Create
        public IActionResult Create()
        {
            ViewData["RecipeId"] = new SelectList(_context.Recipes, "Id", "Id");
            ViewData["CustomerId"] = new SelectList(_context.Customer, "UserId", "UserId");
            return View();
        }

        // POST: CustomerRecipes/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("RecipeId,CustomerId")] CustomerRecipes customerRecipes)
        {
            if (ModelState.IsValid)
            {
                _context.Add(customerRecipes);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["RecipeId"] = new SelectList(_context.Recipes, "Id", "Id", customerRecipes.RecipeId);
            ViewData["CustomerId"] = new SelectList(_context.Customer, "UserId", "UserId", customerRecipes.CustomerId);
            return View(customerRecipes);
        }

        // GET: CustomerRecipes/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var customerRecipes = await _context.customerRecipes.FindAsync(id);
            if (customerRecipes == null)
            {
                return NotFound();
            }
            ViewData["RecipeId"] = new SelectList(_context.Recipes, "Id", "Id", customerRecipes.RecipeId);
            ViewData["CustomerId"] = new SelectList(_context.Customer, "UserId", "UserId", customerRecipes.CustomerId);
            return View(customerRecipes);
        }

        // POST: CustomerRecipes/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("RecipeId,CustomerId")] CustomerRecipes customerRecipes)
        {
            if (id != customerRecipes.RecipeId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(customerRecipes);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CustomerRecipesExists(customerRecipes.RecipeId))
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
            ViewData["RecipeId"] = new SelectList(_context.Recipes, "Id", "Id", customerRecipes.RecipeId);
            ViewData["CustomerId"] = new SelectList(_context.Customer, "UserId", "UserId", customerRecipes.CustomerId);
            return View(customerRecipes);
        }

        // GET: CustomerRecipes/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var customerRecipes = await _context.customerRecipes
                .Include(c => c.Recipes)
                .Include(c => c.customer)
                .FirstOrDefaultAsync(m => m.RecipeId == id);
            if (customerRecipes == null)
            {
                return NotFound();
            }

            return View(customerRecipes);
        }

        // POST: CustomerRecipes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var customerRecipes = await _context.customerRecipes.FindAsync(id);
            _context.customerRecipes.Remove(customerRecipes);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CustomerRecipesExists(int id)
        {
            return _context.customerRecipes.Any(e => e.RecipeId == id);
        }
    }
}
