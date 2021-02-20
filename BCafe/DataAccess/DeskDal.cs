using BCafe.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BCafe.DataAccess
{
    public class DeskDal : IDeskDal
    {
        public void Add(Desk entity)
        {
            using(BCafeContext bCafeEntities = new BCafeContext())
            {
                var result = bCafeEntities.Entry(entity);
                result.State = EntityState.Added;
                bCafeEntities.SaveChanges();
            }
        }

        public void Delete(Desk entity)
        {
            using (BCafeContext bCafeEntities = new BCafeContext())
            {
                var result = bCafeEntities.Entry(entity);
                result.State = EntityState.Deleted;
                bCafeEntities.SaveChanges();
            }
        }

        public List<Desk> GetAll()
        {
            using (BCafeContext bCafeEntities = new BCafeContext())
            {
                return bCafeEntities.Desks.ToList();
            }
        }

        public void Update(Desk entity)
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
