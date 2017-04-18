using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using BusinessGear.Data;
using Microsoft.EntityFrameworkCore;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace BusinessGear.Controllers
{
    public class CollectionController : Controller
    {
        private readonly ApplicationDbContext _context;

        public CollectionController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpGet("/collection")]
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet("/collection/productdetail/{id}")]
        public IActionResult ProductDetail(int id)
        {
            var model = _context.Products.Include(x => x.Category).First(p => p.Id == id);

            if (model == null)
            {
                return NotFound();
            }

            return View(model);
        }
    }
}
