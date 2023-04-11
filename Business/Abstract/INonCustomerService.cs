using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
     public interface INonCustomerService
     {
        void AddNonCustomer(NonCustomer nonCustomer);
        bool IsItOurCustomer(int customerNo);
        void TransferMoney(AccountInformation accountInformation, int customerNo);
        bool IsItOurCard(int cardNo);
        void PayCreditCard(CreditCard creditCard, int cardNo, decimal debt);
     }
}
