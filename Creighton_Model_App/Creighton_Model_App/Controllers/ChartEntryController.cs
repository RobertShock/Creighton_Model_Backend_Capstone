using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Creighton_Model_App.Data;
using Microsoft.AspNetCore.Mvc;
using Creighton_Model_App.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Creighton_Model_App.Controllers
{
    public class ChartEntryController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly UserManager<ApplicationUser> _userManager;

        public ChartEntryController(ApplicationDbContext context, UserManager<ApplicationUser> userManager)
        {
            _context = context;
            _userManager = userManager;
        }
        private Task<ApplicationUser> GetCurrentUserAsync() => _userManager.GetUserAsync(HttpContext.User);

        [HttpPost]
        public async Task<IActionResult> saveEntry(ChartEntry model)
        {
            //gets the current user
            ApplicationUser user = await GetCurrentUserAsync();

            //add chart to database
            ChartEntry chartEntry = new ChartEntry
            {
                User = user,
                DateCreated = model.DateCreated,
                StickerId = model.StickerId,
                DescriptionId = model.DescriptionId
            };

            _context.Add(chartEntry);
            await _context.SaveChangesAsync();

            return RedirectToAction("Index");
        }
        public async Task<IActionResult> Index()
        {
            ApplicationUser user = await GetCurrentUserAsync();
            var entries = _context.ChartEnteries.Include("sticker").Include("description").Where(a => a.User == user).OrderBy(date => date.DateCreated);
            return View(entries.ToList());
        }

        // GET: Continent/Edit/5
        public async Task<IActionResult> Edit(int Id)
        {
            ApplicationUser user = await GetCurrentUserAsync();
            ViewData["DescriptionId"] = new SelectList(_context.Descriptions.OrderBy(description => description.Observation), "DescriptionId", "Observation");
            ViewData["StickerId"] = new SelectList(_context.Stickers, "StickerId", "StickerColor");

            var entries = await _context.ChartEnteries.SingleOrDefaultAsync(a => a.ChartEntryId == Id);
            if (entries == null)
            {
                return NotFound();
            }
            return View(entries);
        }

        // POST: Continent/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, ChartEntry chartEntry)
        {
            if (id != chartEntry.ChartEntryId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(chartEntry);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (id != chartEntry.ChartEntryId)
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction("Index");
            }
            return View(chartEntry);
        }

        // GET: Continent/Delete/5
        public async Task<IActionResult> Delete(int id)
        {
            ViewData["DescriptionId"] = new SelectList(_context.Descriptions.OrderBy(description => description.Observation), "DescriptionId", "Observation");
            ViewData["StickerId"] = new SelectList(_context.Stickers, "StickerId", "StickerColor");
       

            if (id == null)
            {
                return NotFound();
            }

            var entries = await _context.ChartEnteries.SingleOrDefaultAsync(a => a.ChartEntryId == id);
            if (entries == null)
            {
                return NotFound();
            }
            return View(entries);
        }

        // POST: Continent/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var entries = await _context.ChartEnteries.SingleOrDefaultAsync(a => a.ChartEntryId == id);
            _context.ChartEnteries.Remove(entries);
            await _context.SaveChangesAsync();
            return RedirectToAction("Index");
        }

        private bool ChartEntryExists(int id)
        {
            return _context.ChartEnteries.Any(e => e.ChartEntryId == id);
        }
    }
}
 





