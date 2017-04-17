using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BusinessGear.Controllers
{
    public class ProductsController : Controller
    {

        // GET: /Products/
        public IActionResult Index()
        {
            if (Request.Cookies["loggedIn"] == null)
            {
                return RedirectToAction("Login", "Admin");
            }


            return View();
        }
    }
}
