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
    public class NonCustomerManager : INonCustomerService
    {
        private INonCustomerDal _nonCustomerDal;
        public NonCustomerManager(INonCustomerDal nonCustomerDal)
        {
            _nonCustomerDal = nonCustomerDal;
        }
        public void AddNonCustomer(NonCustomer nonCustomer)
        {
            _nonCustomerDal.AddNonCustomer(nonCustomer);
        }

        public bool IsItOurCard(int cardNo)
        {
            return _nonCustomerDal.IsItOurCard(cardNo);
        }

        public bool IsItOurCustomer(int customerNo)
        {
            return _nonCustomerDal.IsItOurCustomer(customerNo);
        }

        public void PayCreditCard(CreditCard creditCard, int cardNo, decimal debt)
        {
            _nonCustomerDal.PayCreditCard(creditCard ,cardNo, debt);
        }

        public void TransferMoney(AccountInformation accountInformation, int customerNo)
        {
            _nonCustomerDal.TransferMoney(accountInformation, customerNo);
        }
    }
}
