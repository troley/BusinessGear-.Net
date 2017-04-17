using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BusinessGear.Data;
using BusinessGear.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MySql.Data.MySqlClient;

namespace BusinessGear.Controllers.Rest
{
    [Produces("application/json")]
    [Route("api/products")]
    public class RestProductsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public RestProductsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET api/Products
        [HttpGet]
        public IEnumerable<Product> Get()
        {
            var allProducts = _context.Products.AsEnumerable();
            return allProducts;
        }

        // GET api/Products/5
        [HttpGet("{id}")]
        public IEnumerable<Product> Get(int id)
        {
            var productById = _context.Products.Where(p => p.Category.Id == id);
            return productById;
        }

        // POST api/Products
        [HttpPost]
        public void Post([FromBody]string value)
        {

        }

        // PUT api/Products/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/Products/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}