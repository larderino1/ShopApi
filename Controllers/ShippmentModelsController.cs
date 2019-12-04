using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ShopApi.Models;

namespace ShopApi.Controllers
{
    public class ShippmentModelsController : Controller
    {
        private readonly ShopContext _context;

        public ShippmentModelsController(ShopContext context)
        {
            _context = context;
        }

        // GET: ShippmentModels
        public async Task<IActionResult> Index()
        {
            var shopContext = _context.Shippments.Include(s => s.Shop);
            return View(await shopContext.ToListAsync());
        }

        // GET: ShippmentModels/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var shippmentModel = await _context.Shippments
                .Include(s => s.Shop)
                .FirstOrDefaultAsync(m => m.ShippmentId == id);
            if (shippmentModel == null)
            {
                return NotFound();
            }

            return View(shippmentModel);
        }

        // GET: ShippmentModels/Create
        public IActionResult Create()
        {
            ViewData["ShopId"] = new SelectList(_context.Shops, "ShopId", "ShopCountry");
            return View();
        }

        // POST: ShippmentModels/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ShippmentId,UserName,UserSurname,UserEmail,UserPhone,Type,ShippmentAdress,ShippmentDestination,PostOfficeNumber,PostOfficeAdress,ShippmentPrice,ShopId")] ShippmentModel shippmentModel)
        {
            if (ModelState.IsValid)
            {
                _context.Add(shippmentModel);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["ShopId"] = new SelectList(_context.Shops, "ShopId", "ShopCountry", shippmentModel.ShopId);
            return View(shippmentModel);
        }

        // GET: ShippmentModels/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var shippmentModel = await _context.Shippments.FindAsync(id);
            if (shippmentModel == null)
            {
                return NotFound();
            }
            ViewData["ShopId"] = new SelectList(_context.Shops, "ShopId", "ShopCountry", shippmentModel.ShopId);
            return View(shippmentModel);
        }

        // POST: ShippmentModels/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ShippmentId,UserName,UserSurname,UserEmail,UserPhone,Type,ShippmentAdress,ShippmentDestination,PostOfficeNumber,PostOfficeAdress,ShippmentPrice,ShopId")] ShippmentModel shippmentModel)
        {
            if (id != shippmentModel.ShippmentId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(shippmentModel);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ShippmentModelExists(shippmentModel.ShippmentId))
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
            ViewData["ShopId"] = new SelectList(_context.Shops, "ShopId", "ShopCountry", shippmentModel.ShopId);
            return View(shippmentModel);
        }

        // GET: ShippmentModels/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var shippmentModel = await _context.Shippments
                .Include(s => s.Shop)
                .FirstOrDefaultAsync(m => m.ShippmentId == id);
            if (shippmentModel == null)
            {
                return NotFound();
            }

            return View(shippmentModel);
        }

        // POST: ShippmentModels/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var shippmentModel = await _context.Shippments.FindAsync(id);
            _context.Shippments.Remove(shippmentModel);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ShippmentModelExists(int id)
        {
            return _context.Shippments.Any(e => e.ShippmentId == id);
        }
    }
}
