using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Creighton_Model_App.Data;
using Microsoft.AspNetCore.Mvc;
using Creighton_Model_App.Models;
using Microsoft.AspNetCore.Identity;


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
        public async Task<IActionResult> saveEntry(ChartEntryViewModel model)
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
            var entries = _context.ChartEnteries.Where(a => a.User == user);
            return View(entries.ToList());
        }


    }
}





