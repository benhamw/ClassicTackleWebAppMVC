using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using FlyrodWebAppMVC;
using FlyrodWebAppMVC.Models;
using System.Xml.Linq;

namespace FlyrodWebAppMVC.Controllers
{
    public class MakersController : Controller
    {
        private readonly FlyrodContext _context;

        public MakersController(FlyrodContext context)
        {
            _context = context;
        }

        // GET: Makers
        public async Task<IActionResult> Index()
        {
              return View(await _context.Makers.OrderBy(m => m.Name).ToListAsync());
        }
        
        // GET: Makers/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Makers == null)
            {
                return NotFound();
            }

            var maker = await _context.Makers
                .FirstOrDefaultAsync(m => m.Id == id);
            if (maker == null)
            {
                return NotFound();
            }

            return View(maker);
        }

        // GET: Makers/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Makers/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Name,YearFounded,Type")] Maker maker)
        {
            ModelState.Remove("Flyrods");

            if (ModelState.IsValid)
            {
                _context.Add(maker);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(maker);
        }

        // GET: Makers/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Makers == null)
            {
                return NotFound();
            }

            var maker = await _context.Makers.FindAsync(id);
            if (maker == null)
            {
                return NotFound();
            }
            return View(maker);
        }

        // POST: Makers/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Name,YearFounded,Type")] Maker maker)
        {
            if (id != maker.Id)
            {
                return NotFound();
            }

            ModelState.Remove("Flyrods");

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(maker);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!MakerExists(maker.Id))
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
            return View(maker);
        }

        // GET: Makers/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Makers == null)
            {
                return NotFound();
            }

            var maker = await _context.Makers
                .FirstOrDefaultAsync(m => m.Id == id);
            if (maker == null)
            {
                return NotFound();
            }

            return View(maker);
        }

        // POST: Makers/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Makers == null)
            {
                return Problem("Entity set 'FlyrodContext.Maker'  is null.");
            }
            var maker = await _context.Makers.FindAsync(id);
            if (maker != null)
            {
                _context.Makers.Remove(maker);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool MakerExists(int id)
        {
          return _context.Makers.Any(e => e.Id == id);
        }
    }
}
