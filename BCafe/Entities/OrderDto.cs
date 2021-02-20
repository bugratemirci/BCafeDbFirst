using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BCafe.Entities
{
    public class OrderDto
    {
        public int Id { get; set; }
        public string DeskName { get; set; }
        public string ProductName { get; set; }
        public decimal OrderPrice { get; set; }
    }
}
