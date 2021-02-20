﻿using BCafe.DataAccess;
using BCafe.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BCafe.Business
{
    public class CategoryManager : ICategoryService
    {
        ICategoryDal categoryDal;

        public CategoryManager(ICategoryDal categoryDal)
        {
            this.categoryDal = categoryDal;
        }

        public void Add(Category category)
        {
            categoryDal.Add(category);
        }

        public void Delete(Category category)
        {
            categoryDal.Delete(category);
        }

        public List<Category> GetAll()
        {
            return categoryDal.GetAll();
        }

        public List<Category> GetByName(string name)
        {
            using(BCafeContext bCafeEntities = new BCafeContext())
            {
                return bCafeEntities.Categories.Where(c => c.Name.Contains(name)).ToList();
            }
        }

        public void Update(Category category)
        {
            categoryDal.Update(category);
        }
    }
}
