using BCafe.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BCafe.Business
{
    public interface IReceiptService
    {
        List<Receipt> GetAll();
        void Add(Receipt receipt);
        void Update(Receipt receipt);
        void Delete(Receipt receipt);
    }
}
