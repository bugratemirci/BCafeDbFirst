using BCafe.DataAccess;
using BCafe.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BCafe.Business
{
    public class ProductManager : IProductService
    {
        IProductDal _productDal;

        public ProductManager(IProductDal productDal)
        {
            _productDal = productDal;
        }

        public void Add(Product product)
        {
            _productDal.Add(product);
        }

        public void Delete(Product product)
        {
            _productDal.Delete(product);
        }

        public List<Product> GetAll()
        {
            return _productDal.GetAll();
        }

        public List<Product> SearchByName(string key)
        {
            
            using (BCafeContext bCafeEntities = new BCafeContext())
            {
                return bCafeEntities.Products.Where(p => p.Name.Contains(key)).ToList();
            }
        }

        public void Update(Product product)
        {
            _productDal.Update(product);
        }
        public List<ProductDto> ShowProducts()
        {
            using (BCafeContext bCafeEntities = new BCafeContext())
            {
                var categories = bCafeEntities.Categories;
                var products = bCafeEntities.Products;

                var result = from p in products
                             join c in categories
                             on p.CategoryId equals c.Id
                             select new ProductDto
                             {
                                 CategoryName = c.Name,
                                 Name = p.Name,
                                 UnitPrice = p.UnitPrice,
                                 UnitsInStock = p.UnitsInStock,
                                 Id = p.Id
                             };
                return result.ToList();
            }
        }
        public Product GetById(int productId)
        {
            using(BCafeContext bCafeEntities = new BCafeContext())
            {
                var result = bCafeEntities.Products.FirstOrDefault(p => p.Id == productId);
                return result;
            }
        }
    }
}
