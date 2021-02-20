using BCafe.DataAccess;
using BCafe.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BCafe.Business
{
    public class DeskManager : IDeskService
    {
        IDeskDal deskDal_;

        public DeskManager(IDeskDal deskDal_)
        {
            this.deskDal_ = deskDal_;
        }

        public void Add(Desk desk)
        {
            deskDal_.Add(desk);
        }

        public void Delete(Desk desk)
        {
            deskDal_.Delete(desk);
        }

        public List<Desk> GetAll()
        {
            return deskDal_.GetAll();
        }

        public void Update(Desk desk)
        {
            deskDal_.Update(desk);
        }
        public int DeskCount()
        {
            using(BCafeContext entities = new BCafeContext())
            {
                return entities.Desks.Count();
            }
        }
        public Desk GetDesk(string deskName)
        {
            using (BCafeContext entities = new BCafeContext())
            {
                return entities.Desks.FirstOrDefault(d => d.DeskName == deskName);
            }
        }
    }
}
