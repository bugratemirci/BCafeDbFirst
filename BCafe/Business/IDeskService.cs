
using BCafe.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BCafe.Business
{
    public interface IDeskService
    {
        List<Desk> GetAll();
        void Add(Desk desk);
        void Update(Desk desk);
        void Delete(Desk desk);
    }
}
