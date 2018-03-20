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
    public class ChartController : Controller
    {  
        private ApplicationDbContext _context;
        private DateTime DateTime;
        private ICollection<Sticker> stickers;
        private ICollection<Description> descriptions;
        private readonly UserManager<ApplicationUser> _userManager;

        public ChartController(ApplicationDbContext ctx, UserManager<ApplicationUser> userManager)
        {
            _context = ctx;
            _userManager = userManager;
        }
        private Task<ApplicationUser> GetCurrentUserAsync() => _userManager.GetUserAsync(HttpContext.User);

        public async Task<IActionResult> UserChartEntries()
        {
            ApplicationUser user = await GetCurrentUserAsync();

            var model = new ChartViewModel();
            model.Chart = GetUserChartEntries(user);
            return View(model);
        }

        private ICollection<Chart> GetUserChartEntries(ApplicationUser user)
        {
            throw new NotImplementedException();
        }

        public async Task<IActionResult> Track(DateTime DateTime, string sticker, string description)
        {
            //gets the current user
            ApplicationUser user = await GetCurrentUserAsync();

            //add entry to database
            Chart chart = new Chart
            {
                DateTime = DateTime,
                Stickers = stickers,
                Descriptions = descriptions
            };
          
            _context.Add(chart);
        }



        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}



