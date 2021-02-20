using BCafe.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BCafe.DataAccess
{
    public class ReceiptDal : IReceiptDal
    {
        public void Add(Receipt entity)
        {
            using(BCafeContext bCafeEntities = new BCafeContext())
            {
                var result = bCafeEntities.Entry(entity);
                result.State = EntityState.Added;
                bCafeEntities.SaveChanges();
            }
        }

        public void Delete(Receipt entity)
        {
            using (BCafeContext bCafeEntities = new BCafeContext())
            {
                var result = bCafeEntities.Entry(entity);
                result.State = EntityState.Deleted;
                bCafeEntities.SaveChanges();
            }
        }

        public List<Receipt> GetAll()
        {
            using (BCafeContext bCafeEntities = new BCafeContext())
            {
                return bCafeEntities.Receipts.ToList();
            }
        }

        public void Update(Receipt entity)
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
