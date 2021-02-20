using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BCafe.Entities
{
    public class Desk : IEntity
    {
        public int Id { get; set; }
        public string DeskName { get; set; }

    }
}
