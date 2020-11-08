using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using RentalKendaraan_201810140035.Models;

namespace RentalKendaraan_201810140035.Controllers
{
    public class JnsKendaraansController : Controller
    {
        private readonly RentKendaraanContext _context;

        public JnsKendaraansController(RentKendaraanContext context)
        {
            _context = context;
        }

        // GET: JnsKendaraans
        public async Task<IActionResult> Index()
        {
            var rentKendaraanContext = _context.JnsKendaraan.Include(j => j.JenisKendaraanNavigation);
            return View(await rentKendaraanContext.ToListAsync());
        }

        // GET: JnsKendaraans/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var jnsKendaraan = await _context.JnsKendaraan
                .Include(j => j.JenisKendaraanNavigation)
                .FirstOrDefaultAsync(m => m.JenisKendaraan == id);
            if (jnsKendaraan == null)
            {
                return NotFound();
            }

            return View(jnsKendaraan);
        }

        // GET: JnsKendaraans/Create
        public IActionResult Create()
        {
            ViewData["JenisKendaraan"] = new SelectList(_context.Kendaraan, "IdKendaraan", "IdKendaraan");
            return View();
        }

        // POST: JnsKendaraans/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("JenisKendaraan,NamaJenisKendaraan")] JnsKendaraan jnsKendaraan)
        {
            if (ModelState.IsValid)
            {
                _context.Add(jnsKendaraan);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["JenisKendaraan"] = new SelectList(_context.Kendaraan, "IdKendaraan", "IdKendaraan", jnsKendaraan.JenisKendaraan);
            return View(jnsKendaraan);
        }

        // GET: JnsKendaraans/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var jnsKendaraan = await _context.JnsKendaraan.FindAsync(id);
            if (jnsKendaraan == null)
            {
                return NotFound();
            }
            ViewData["JenisKendaraan"] = new SelectList(_context.Kendaraan, "IdKendaraan", "IdKendaraan", jnsKendaraan.JenisKendaraan);
            return View(jnsKendaraan);
        }

        // POST: JnsKendaraans/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("JenisKendaraan,NamaJenisKendaraan")] JnsKendaraan jnsKendaraan)
        {
            if (id != jnsKendaraan.JenisKendaraan)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(jnsKendaraan);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!JnsKendaraanExists(jnsKendaraan.JenisKendaraan))
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
            ViewData["JenisKendaraan"] = new SelectList(_context.Kendaraan, "IdKendaraan", "IdKendaraan", jnsKendaraan.JenisKendaraan);
            return View(jnsKendaraan);
        }

        // GET: JnsKendaraans/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var jnsKendaraan = await _context.JnsKendaraan
                .Include(j => j.JenisKendaraanNavigation)
                .FirstOrDefaultAsync(m => m.JenisKendaraan == id);
            if (jnsKendaraan == null)
            {
                return NotFound();
            }

            return View(jnsKendaraan);
        }

        // POST: JnsKendaraans/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var jnsKendaraan = await _context.JnsKendaraan.FindAsync(id);
            _context.JnsKendaraan.Remove(jnsKendaraan);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool JnsKendaraanExists(int id)
        {
            return _context.JnsKendaraan.Any(e => e.JenisKendaraan == id);
        }
    }
}
