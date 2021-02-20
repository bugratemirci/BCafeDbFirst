using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BCafe.Entities
{
    public class Order : IEntity
    {
        public int Id { get; set; }
        public int DeskId { get; set; }
        public int ProductId { get; set; }
        public decimal OrderPrice { get; set; }
    }
}
