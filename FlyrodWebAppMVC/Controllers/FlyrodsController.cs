using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using FlyrodWebAppMVC;
using FlyrodWebAppMVC.Models;

namespace FlyrodWebAppMVC.Controllers
{
    public class FlyrodsController : Controller
    {
        private readonly FlyrodContext _context;

        public FlyrodsController(FlyrodContext context)
        {
            _context = context;
        }

        // GET: Flyrods
        public async Task<IActionResult> Index()
        {
            var flyrodContext = _context.Flyrods.Include(f => f.Maker);
            return View(await flyrodContext.OrderBy(f => f.Maker.Name).ToListAsync());
        }

        // GET: Flyrods/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Flyrods == null)
            {
                return NotFound();
            }

            var flyrod = await _context.Flyrods
                .Include(f => f.Maker)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (flyrod == null)
            {
                return NotFound();
            }

            return View(flyrod);
        }

        // GET: Flyrods/Create
        public IActionResult Create()
        {
            ViewData["MakerId"] = new SelectList(_context.Makers, "Id", "Name");
            return View();
        }

        // POST: Flyrods/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,MakerId,Model,LengthFeet,Sections,LineWeight,YearMade,Type,Construction,RodImage")] Flyrod flyrod)
        {
            //if (ModelState.IsValid)
            bool run = true;
            if (run)
            {
                _context.Add(flyrod);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["MakerId"] = new SelectList(_context.Makers, "Id", "Id", flyrod.MakerId);
            return View(flyrod);
        }

        // GET: Flyrods/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Flyrods == null)
            {
                return NotFound();
            }

            var flyrod = await _context.Flyrods.FindAsync(id);
            if (flyrod == null)
            {
                return NotFound();
            }
            ViewData["MakerId"] = new SelectList(_context.Makers, "Id", "Id", flyrod.MakerId);
            return View(flyrod);
        }

        // POST: Flyrods/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,MakerId,Model,LengthFeet,Sections,LineWeight,YearMade,Type,Construction,RodImage")] Flyrod flyrod)
        {
            if (id != flyrod.Id)
            {
                return NotFound();
            }

            bool run = true;
            if (run)
            //if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(flyrod);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!FlyrodExists(flyrod.Id))
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
            ViewData["MakerId"] = new SelectList(_context.Makers, "Id", "Id", flyrod.MakerId);
            return View(flyrod);
        }

        // GET: Flyrods/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Flyrods == null)
            {
                return NotFound();
            }

            var flyrod = await _context.Flyrods
                .Include(f => f.Maker)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (flyrod == null)
            {
                return NotFound();
            }

            return View(flyrod);
        }

        // POST: Flyrods/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Flyrods == null)
            {
                return Problem("Entity set 'FlyrodContext.Flyrod'  is null.");
            }
            var flyrod = await _context.Flyrods.FindAsync(id);
            if (flyrod != null)
            {
                _context.Flyrods.Remove(flyrod);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool FlyrodExists(int id)
        {
          return _context.Flyrods.Any(e => e.Id == id);
        }
    }
}
