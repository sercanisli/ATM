using DataAccess.Abstract;
using DataAccess.Concrete.Context;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfBillDal : IBillDal
    {
        public PayBill GetBillById(byte billId)
        {
            using(MyBankContext myBankContext = new MyBankContext())
            {
                var result = myBankContext.PayBills.Where(p => p.BillId == billId).FirstOrDefault();
                return result;
            }
        }

        public List<Bill> GetBillItem()
        {
            using(MyBankContext myBankContext = new MyBankContext())
            {
                return myBankContext.Set<Bill>().ToList();
            }
        }

        public bool IsCutomerHaveBill(int customerId, int billId)
        {
            using(MyBankContext myBankContext = new MyBankContext())
            {
                var result = myBankContext.Set<PayBill>().Any(p => p.CustomerId == customerId && p.BillId == billId);
                return result;
            }
        }

        public void PayBill(PayBill payBill, int id)
        {
            using(MyBankContext myBankContext = new MyBankContext())
            {
                var result = myBankContext.PayBills.Where(p => p.CustomerId == id).First();
                result.Price = result.Price - payBill.Price;
                myBankContext.Entry(result).State = EntityState.Modified;
                myBankContext.SaveChanges();
            }
        }
    }
}
