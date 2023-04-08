using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class BillManager : IBillService
    {
        private IBillDal _billDal;
        public BillManager(IBillDal billDal)
        {
            _billDal = billDal;
        }

        public PayBill GetBillById(byte billId)
        {
            return _billDal.GetBillById(billId);
        }

        public List<Bill> GetBillItem()
        {
            return _billDal.GetBillItem();
        }

        public bool IsCutomerHaveBill(int customerId, int billId)
        {
            var result = _billDal.IsCutomerHaveBill(customerId, billId);
            return result;
        }

        public void PayBill(PayBill payBill, int id)
        {
            _billDal.PayBill(payBill, id);
        }
    }
}
