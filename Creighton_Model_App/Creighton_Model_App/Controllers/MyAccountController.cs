using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Creighton_Model_App.Data;
using Creighton_Model_App.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

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
            var user = await _userManager.GetUserAsync(User);
            return View();
        }

        private System.Security.Principal.IIdentity GetIdentity()
        {
            return User.Identity;
        }
    }
}



