using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Security.Cryptography;
using System.Threading.Tasks;
using BusinessGear.Data;
using BusinessGear.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace BusinessGear.Controllers
{
    public class AdminController : Controller
    {
        private ApplicationDbContext _context;
        private CookieOptions _options;

        public AdminController(ApplicationDbContext context)
        {
            _context = context;
            _options = new CookieOptions();
        }

        // GET: /Admin/Login
        [HttpGet("/admin/login")]
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Login(Admin model)
        {

            var admin = _context.Admins.FirstOrDefault(
                a => a.Password == model.Password && a.Username == model.Username);
            if (ModelState.IsValid)
            {
                if (admin != null)
                {
                    _options.Expires = DateTime.Now.AddMinutes(10);
                    Response.Cookies.Append("loggedIn", "loggedIn", _options);
                    return RedirectToAction("Index", "Products");
                }
            }

            return RedirectToAction("Login");
        }

    }
}
