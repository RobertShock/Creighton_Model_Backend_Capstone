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

        // GET: MyAccount/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: MyAccount/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: MyAccount/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: MyAccount/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: MyAccount/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: MyAccount/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: MyAccount/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}



