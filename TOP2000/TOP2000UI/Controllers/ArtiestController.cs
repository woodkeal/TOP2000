using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using TOP2000UI.Models;

namespace TOP2000UI.Controllers
{
    public class ArtiestController : Controller
    {
        private readonly TOP2000Context _context;

        public ArtiestController(TOP2000Context context)
        {
            _context = context;
        }

        // GET: Artiest
        public async Task<IActionResult> Index()
        {
            return View(await _context.Artiests.ToListAsync());
        }

        // GET: Artiest/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var artiest = await _context.Artiests
                .FirstOrDefaultAsync(m => m.Artiestid == id);
            if (artiest == null)
            {
                return NotFound();
            }

            return View(artiest);
        }

        // GET: Artiest/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Artiest/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Artiestid,Naam")] Artiest artiest)
        {
            if (ModelState.IsValid)
            {
                _context.Add(artiest);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(artiest);
        }

        // GET: Artiest/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var artiest = await _context.Artiests.FindAsync(id);
            if (artiest == null)
            {
                return NotFound();
            }
            return View(artiest);
        }

        // POST: Artiest/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Artiestid,Naam")] Artiest artiest)
        {
            if (id != artiest.Artiestid)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(artiest);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ArtiestExists(artiest.Artiestid))
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
            return View(artiest);
        }

        // GET: Artiest/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var artiest = await _context.Artiests
                .FirstOrDefaultAsync(m => m.Artiestid == id);
            if (artiest == null)
            {
                return NotFound();
            }

            return View(artiest);
        }

        // POST: Artiest/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var artiest = await _context.Artiests.FindAsync(id);
            _context.Artiests.Remove(artiest);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ArtiestExists(int id)
        {
            return _context.Artiests.Any(e => e.Artiestid == id);
        }
    }
}
