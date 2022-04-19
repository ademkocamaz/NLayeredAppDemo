using Northwind.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Northwind.Business.Abstract
{
    public interface IProductService
    {
        List<Product> GetAll();
        List<Product> GetProductByProductName(string productName);
        List<Product> GetProductsByCategory(int categoryId);
        void Add(Product product);
        void Update(Product product);
        void Delete(Product product);
    }
}
