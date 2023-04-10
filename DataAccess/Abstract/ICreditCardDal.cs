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
        CreditCard LoadDebt(CreditCard creditCard,int id);

    }
}
