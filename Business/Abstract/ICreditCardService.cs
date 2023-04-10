using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface ICreditCardService
    {
        void ApplyCreditCard(CreditCard creditCard);
        CreditCard GetByCreditCardId(int customerId);
        void PayCreditCardDebt(AccountInformation accountInformation, int id, byte paymentPrefence, decimal debt);
        CreditCard LoadDebt(CreditCard creditCard, int id, byte paymentPreference, decimal debt);
    }
}
