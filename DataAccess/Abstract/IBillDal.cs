using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Abstract
{
    public interface IBillDal
    {
        bool IsCutomerHaveBill(int customerId, int billId);
        List<Bill> GetBillItem();
        PayBill GetBillById(byte billId);
        void PayBill(PayBill payBill, int id);
    }
}
