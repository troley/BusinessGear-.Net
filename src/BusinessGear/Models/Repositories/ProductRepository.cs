using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BusinessGear.Data;
using Microsoft.EntityFrameworkCore;

namespace BusinessGear.Models.Repositories
{
    public class ProductRepository : IProductRepository
    {

        private readonly ApplicationDbContext _context;

        public ProductRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public void Add(Product item)
        {
            _context.Products.Add(item);
            _context.SaveChanges();
        }

        public IEnumerable<Product> GetAll()
        {
            return _context.Products.AsEnumerable();
        }

        public Product Find(int key)
        {
            return _context.Products.Include(p => p.Category).FirstOrDefault(k => k.Id == key);
        }

        public void Remove(int key)
        {
            var product = _context.Products.First(k => k.Id == key);
            _context.Products.Remove(product);
            _context.SaveChanges();
        }

        public void Update(Product item)
        {
            _context.Products.Update(item);
            _context.SaveChanges();
        }

        public IEnumerable<Product> FindAllByCategoryId(int id)
        {
            return _context.Products.Include(p => p.Category).Where(p => p.Category.Category_Id == id);
        }
    }
}
