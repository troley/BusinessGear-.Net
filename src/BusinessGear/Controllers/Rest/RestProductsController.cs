using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BusinessGear.Data;
using BusinessGear.Models;
using BusinessGear.Models.Repositories;
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

        private readonly IProductRepository _productRepo;

        public RestProductsController(IProductRepository productRepository)
        {
            _productRepo = productRepository;
        }

        // GET api/products
        [HttpGet]
        public IEnumerable<Product> GetAllProducts()
        {
            return _productRepo.GetAll();
        }

        [HttpGet("{id}")]
        public Product GetProductById(int id)
        {
            return _productRepo.Find(id);
        }

        // GET api/products/category/5
        [HttpGet("category/{id}")]
        public IEnumerable<Product> GetProductsByCategoryId(int id)
        {
            return _productRepo.FindAllByCategoryId(id);
        }

        // POST api/products
        [HttpPost]
        public void Post([FromBody]string value)
        {

        }

        // PUT api/products/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/products/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}