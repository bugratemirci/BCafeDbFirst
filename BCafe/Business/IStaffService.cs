using BCafe.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BCafe.Business
{
    public interface IStaffService
    {
        List<Staff> GetAll();
        void Add(Staff staff);
        void Update(Staff staff);
        void Delete(Staff staff);
        List<Staff> SearchStaff(string key);
    }
}
