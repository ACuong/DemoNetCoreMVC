using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using DemoDotNetMVC.Models;

namespace DemoDotNetMVC.Controllers
{
    public class ChuyenNganhController : Controller
    {
        private readonly ApplicationDBContext _context;

        public ChuyenNganhController(ApplicationDBContext context)
        {
            _context = context;
        }

        // GET: ChuyenNganh
        public async Task<IActionResult> Index()
        {
            var applicationDBContext = _context.ChuyenNganh.Include(c => c.Khoa);
            return View(await applicationDBContext.ToListAsync());
        }

        // GET: ChuyenNganh/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var chuyenNganh = await _context.ChuyenNganh
                .Include(c => c.Khoa)
                .FirstOrDefaultAsync(m => m.ChuyenNganhId == id);
            if (chuyenNganh == null)
            {
                return NotFound();
            }

            return View(chuyenNganh);
        }

        // GET: ChuyenNganh/Create
        public IActionResult Create()
        {
            ViewData["KhoaId"] = new SelectList(_context.Khoa, "KhoaId", "KhoaName");
            return View();
        }

        // POST: ChuyenNganh/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ChuyenNganhId,ChuyenNganhName,KhoaId")] ChuyenNganh chuyenNganh)
        {
            if (ModelState.IsValid)
            {
                _context.Add(chuyenNganh);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["KhoaId"] = new SelectList(_context.Khoa, "KhoaId", "KhoaName", chuyenNganh.KhoaId);
            return View(chuyenNganh);
        }

        // GET: ChuyenNganh/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var chuyenNganh = await _context.ChuyenNganh.FindAsync(id);
            if (chuyenNganh == null)
            {
                return NotFound();
            }
            ViewData["KhoaId"] = new SelectList(_context.Khoa, "KhoaId", "KhoaName", chuyenNganh.KhoaId);
            return View(chuyenNganh);
        }

        // POST: ChuyenNganh/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ChuyenNganhId,ChuyenNganhName,KhoaId")] ChuyenNganh chuyenNganh)
        {
            if (id != chuyenNganh.ChuyenNganhId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(chuyenNganh);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ChuyenNganhExists(chuyenNganh.ChuyenNganhId))
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
            ViewData["KhoaId"] = new SelectList(_context.Khoa, "KhoaId", "KhoaName", chuyenNganh.KhoaId);
            return View(chuyenNganh);
        }

        // GET: ChuyenNganh/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var chuyenNganh = await _context.ChuyenNganh
                .Include(c => c.Khoa)
                .FirstOrDefaultAsync(m => m.ChuyenNganhId == id);
            if (chuyenNganh == null)
            {
                return NotFound();
            }

            return View(chuyenNganh);
        }

        // POST: ChuyenNganh/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var chuyenNganh = await _context.ChuyenNganh.FindAsync(id);
            _context.ChuyenNganh.Remove(chuyenNganh);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ChuyenNganhExists(int id)
        {
            return _context.ChuyenNganh.Any(e => e.ChuyenNganhId == id);
        }
    }
}
