using FluentValidation;
using Northwind.Business.Abstract;
using Northwind.Business.Utilities;
using Northwind.Business.ValidationRules.FluentValidation;
using Northwind.DataAccess.Abstract;
using Northwind.DataAccess.Concrete.EntityFramework;
using Northwind.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Northwind.Business.Concrete
{
    public class ProductManager : IProductService
    {
        //EfProductDal productDal = new EfProductDal();
        IProductDal productDal;

        public ProductManager(IProductDal productDal)
        {
            this.productDal = productDal;
        }

        public void Add(Product product)
        {
            ValidationTool.Validate(new ProductValidator(), product);
            productDal.Add(product);
        }

        public void Delete(Product product)
        {
            productDal.Delete(product);
        }

        public List<Product> GetAll()
        {
            return productDal.GetAll();
        }

        public List<Product> GetProductByProductName(string productName)
        {
            return productDal.GetAll(p => p.ProductName.Contains(productName));
        }

        public List<Product> GetProductsByCategory(int categoryId)
        {
            return productDal.GetAll(p => p.CategoryId == categoryId);
        }

        public void Update(Product product)
        {
            productDal.Update(product);
        }
    }
}
