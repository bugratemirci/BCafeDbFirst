using System;
using System.Collections.Generic;
using System.Text;

namespace BCafe.Entities
{
    public class Staff : IEntity
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string IdentityNumber { get; set; }
        public string Mail { get; set; }
        public string Phone { get; set; }
        public int Salary { get; set; }
        public string Password { get; set; }
        public string UserName { get; set; }
        public bool IsAdmin { get; set; }
    }
}
