using BCafe.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BCafe.DataAccess
{
    public class OrderDal : IOrderDal
    {
        public void Add(Order entity)
        {
            using(BCafeContext bCafeEntities = new BCafeContext())
            {
                var result = bCafeEntities.Entry(entity);
                result.State = EntityState.Added;
                bCafeEntities.SaveChanges();
            }
        }

        public void Delete(Order entity)
        {
            using (BCafeContext bCafeEntities = new BCafeContext())
            {
                var result = bCafeEntities.Entry(entity);
                result.State = EntityState.Deleted;
                bCafeEntities.SaveChanges();
            }
        }

        public List<Order> GetAll()
        {
            using (BCafeContext bCafeEntities = new BCafeContext())
            {
                return bCafeEntities.Orders.ToList();
            }
        }

        public void Update(Order entity)
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
