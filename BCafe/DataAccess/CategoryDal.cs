
using BCafe.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BCafe.DataAccess
{
    public class CategoryDal : ICategoryDal
    {
        public void Add(Category entity)
        {
            using(BCafeContext bCafeEntities = new BCafeContext())
            {
                var result = bCafeEntities.Entry(entity);
                result.State = EntityState.Added;
                bCafeEntities.SaveChanges();
            }
        }

        public void Delete(Category entity)
        {
            using(BCafeContext bCafeEntities = new BCafeContext())
            {
                var result = bCafeEntities.Entry(entity);
                result.State = EntityState.Deleted;
                bCafeEntities.SaveChanges();
            }
        }

        public List<Category> GetAll()
        {
            using(BCafeContext context = new BCafeContext())
            {
                return context.Categories.ToList();
            }
        }

        public void Update(Category entity)
        {
            using(BCafeContext bCafeEntities = new BCafeContext())
            {
                var result = bCafeEntities.Entry(entity);
                result.State = EntityState.Modified;
                bCafeEntities.SaveChanges();
            }
        }
    }
}
