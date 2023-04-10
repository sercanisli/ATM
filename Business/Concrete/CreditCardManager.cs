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
    public class CreditCardManager : ICreditCardService
    {
        private ICreditCardDal _creditCardDal;
        public CreditCardManager(ICreditCardDal creditCardDal)
        {
            _creditCardDal = creditCardDal;
        }
        public void ApplyCreditCard(CreditCard creditCard)
        {
            Random randomCustomerwNo = new Random();
            int no = randomCustomerwNo.Next(1000000, 9999999);
            creditCard.CardNo = no;

            _creditCardDal.ApplyCreditCard(creditCard);
        }

        public CreditCard GetByCreditCardId(int customerId)
        {
            return _creditCardDal.GetByCreditCardId(customerId);
        }

        public CreditCard LoadDebt(CreditCard creditCard, int id, byte paymentPreference, decimal debt)
        {
            decimal oldDebt =0;
            oldDebt = debt;
            if(paymentPreference==1)
            {
                debt = debt * (40M / 100M);
                creditCard.Debt = oldDebt - debt;
                
            }
            if(paymentPreference==2)
            {
                creditCard.Debt = debt - debt;
            }
            return _creditCardDal.LoadDebt(creditCard,id);
        }

        public void PayCreditCardDebt(AccountInformation accountInformation, int id, byte paymentPrefence, decimal debt)
        {
            if (paymentPrefence==1)
            {
                debt = debt * (40M / 100M);
                accountInformation.Money = accountInformation.Money - debt;
               _creditCardDal.PayCreditCard(accountInformation, id);
                
            }
            if(paymentPrefence==2)
            {
                accountInformation.Money = accountInformation.Money - debt;
               _creditCardDal.PayCreditCard(accountInformation, id);
            }
        }
    }
}
