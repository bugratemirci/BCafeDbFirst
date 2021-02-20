using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BCafe.Entities
{
    public class Receipt : IEntity
    {
        public int Id { get; set; }
        public string Date { get; set; }
        public string Time { get; set; }
        public decimal Amount { get; set; }
    }
}
