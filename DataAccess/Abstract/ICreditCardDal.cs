using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Abstract
{
    public interface ICreditCardDal
    {
        void ApplyCreditCard(CreditCard creditCard);
        CreditCard GetByCreditCardId(int customerId);
        void PayCreditCard(AccountInformation accountInformation, int id);
        //void PayCreditCardNonCustomer(AccountInformation accountInformation, int cardNo);
        CreditCard LoadDebt(CreditCard creditCard,int id);
        CreditCard GetCreditCardByCardNo(int cardNo);
        bool CardNoIsExists(int no);

    }
}
