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
    public class SummarizeRecipeAPIsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public SummarizeRecipeAPIsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: SummarizeRecipeAPIs
        public async Task<IActionResult> Index()
        {
            return View(await _context.SummarizeRecipeAPI.ToListAsync());
        }

        // GET: SummarizeRecipeAPIs/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var summarizeRecipeAPI = await _context.SummarizeRecipeAPI
                .FirstOrDefaultAsync(m => m.id == id);
            if (summarizeRecipeAPI == null)
            {
                return NotFound();
            }

            return View(summarizeRecipeAPI);
        }

        // GET: SummarizeRecipeAPIs/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: SummarizeRecipeAPIs/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("id,title,summary")] SummarizeRecipeAPI summarizeRecipeAPI)
        {
            if (ModelState.IsValid)
            {
                _context.Add(summarizeRecipeAPI);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(summarizeRecipeAPI);
        }

        // GET: SummarizeRecipeAPIs/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var summarizeRecipeAPI = await _context.SummarizeRecipeAPI.FindAsync(id);
            if (summarizeRecipeAPI == null)
            {
                return NotFound();
            }
            return View(summarizeRecipeAPI);
        }

        // POST: SummarizeRecipeAPIs/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("id,title,summary")] SummarizeRecipeAPI summarizeRecipeAPI)
        {
            if (id != summarizeRecipeAPI.id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(summarizeRecipeAPI);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!SummarizeRecipeAPIExists(summarizeRecipeAPI.id))
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
            return View(summarizeRecipeAPI);
        }

        // GET: SummarizeRecipeAPIs/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var summarizeRecipeAPI = await _context.SummarizeRecipeAPI
                .FirstOrDefaultAsync(m => m.id == id);
            if (summarizeRecipeAPI == null)
            {
                return NotFound();
            }

            return View(summarizeRecipeAPI);
        }

        // POST: SummarizeRecipeAPIs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var summarizeRecipeAPI = await _context.SummarizeRecipeAPI.FindAsync(id);
            _context.SummarizeRecipeAPI.Remove(summarizeRecipeAPI);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool SummarizeRecipeAPIExists(int id)
        {
            return _context.SummarizeRecipeAPI.Any(e => e.id == id);
        }
    }
}
