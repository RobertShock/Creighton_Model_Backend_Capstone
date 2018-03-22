using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Creighton_Model_App.Data;
using Creighton_Model_App.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Creighton_Model_App.Controllers
{
    public class MyAccountController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly UserManager<ApplicationUser> _userManager;

        public MyAccountController(ApplicationDbContext context, UserManager<ApplicationUser> userManager)
        {
            _context = context;
            _userManager = userManager;
        }

        public async Task<IActionResult> Index()
        {
            ViewData["DescriptionId"] = new SelectList(_context.Descriptions.OrderBy(description => description.Observation), "DescriptionId", "Observation");
            ViewData["StickerId"] = new SelectList(_context.Stickers, "StickerId", "StickerColor");
            var user = await _userManager.GetUserAsync(User);
            return View();
        }

        private System.Security.Principal.IIdentity GetIdentity()
        {
            return User.Identity;
        }
    }
}



