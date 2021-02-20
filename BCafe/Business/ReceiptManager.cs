using BCafe.DataAccess;
using BCafe.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BCafe.Business
{
    public class ReceiptManager : IReceiptService
    {
        IReceiptDal _receiptDal;

        public ReceiptManager(IReceiptDal receiptDal)
        {
            _receiptDal = receiptDal;
        }

        public void Add(Receipt receipt)
        {
            _receiptDal.Add(receipt);
        }

        public void Delete(Receipt receipt)
        {
            _receiptDal.Delete(receipt);
        }

        public List<Receipt> GetAll()
        {
            return _receiptDal.GetAll();
        }

        public void Update(Receipt receipt)
        {
            _receiptDal.Update(receipt);
        }
        public decimal DailySell(string date)
        {
            using(BCafeContext bCafeEntities = new BCafeContext())
            {
                var receipts = bCafeEntities.Receipts;
                var result1 = (from r in receipts
                               where r.Date == date
                               select r.Id).Count();
                if(result1 == 0)
                {
                    return 0;
                }
                else
                {
                    var result = (from r in receipts
                                  where r.Date == date
                                  select r.Amount).Sum();
                    return result;
                }
            }
        }
      
    }
}
