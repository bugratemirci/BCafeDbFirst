using BCafe.DataAccess;
using BCafe.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BCafe.Business
{
    public class StaffManager : IStaffService
    {
        IStaffDal staffDal_;

        public StaffManager(IStaffDal staffDal_)
        {
            this.staffDal_ = staffDal_;
        }

        public void Add(Staff staff)
        {
            staffDal_.Add(staff);
        }

        public void Delete(Staff staff)
        {
            staffDal_.Delete(staff);
        }

        public List<Staff> GetAll()
        {
            return staffDal_.GetAll();
        }

        public void Update(Staff staff)
        {
            staffDal_.Update(staff);
        }
        public List<Staff> SearchStaff(string key)
        {
            using (BCafeContext bCafeEntities = new BCafeContext())
            {
                return bCafeEntities.Staffs.Where(s => s.FirstName.Contains(key)).ToList();
            }
        }
        public Staff GetStaff(string userName)
        {
            using (BCafeContext bCafeEntities = new BCafeContext())
            {
                return bCafeEntities.Staffs.FirstOrDefault(s => s.UserName == userName);
            }
        }
        public Staff GetStaff(int id)
        {
            using (BCafeContext bCafeEntities = new BCafeContext())
            {
                return bCafeEntities.Staffs.FirstOrDefault(s => s.Id == id);
            }
        }
        public bool Control(string userName, string password)
        {
            using (BCafeContext bCafeEntities = new BCafeContext())
            {
                return bCafeEntities.Staffs.Any(s => s.UserName == userName && s.Password == password);
            }

        }
        public bool AddControl(string userName, string identityNo, string mail)
        {
            using (BCafeContext bCafeEntities = new BCafeContext())
            {
                return bCafeEntities.Staffs.Any(p => p.IdentityNumber == identityNo || p.UserName == userName || p.Mail == mail);
            }
        }
        public bool CheckPassword(string userName, string identityNumber)
        {
            using (BCafeContext bCafeEntities = new BCafeContext())
            {
                return bCafeEntities.Staffs.Any(s => s.UserName == userName && s.IdentityNumber == identityNumber);
            }

        }
    }
}
