using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BusinessGear.Models.Repositories
{
    public interface IProductRepository : IRepository<Product>
    {
        IEnumerable<Product> FindAllByCategoryId(int id);
    }
}
