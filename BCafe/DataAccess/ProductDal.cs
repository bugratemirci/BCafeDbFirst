using BCafe.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BCafe.DataAccess
{
    public class ProductDal : IProductDal
    {
        public void Add(Product entity)
        {
            using(BCafeContext bCafeEntities = new BCafeContext())
            {
                var result = bCafeEntities.Entry(entity);
                result.State = EntityState.Added;
                bCafeEntities.SaveChanges();
            }
        }

        public void Delete(Product entity)
        {
            using (BCafeContext bCafeEntities = new BCafeContext())
            {
                var result = bCafeEntities.Entry(entity);
                result.State = EntityState.Deleted;
                bCafeEntities.SaveChanges();
            }
        }

        public List<Product> GetAll()
        {
            using (BCafeContext bCafeEntities = new BCafeContext())
            {
                return bCafeEntities.Products.ToList();
            }
        }

        public void Update(Product entity)
        {
            using (BCafeContext bCafeEntities = new BCafeContext())
            {
                var result = bCafeEntities.Entry(entity);
                result.State = EntityState.Modified;
                bCafeEntities.SaveChanges();
            }
        }
    }
}
