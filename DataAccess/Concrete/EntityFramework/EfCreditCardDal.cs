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
    public class EfCreditCardDal : ICreditCardDal
    {
        public void ApplyCreditCard(CreditCard creditCard)
        {
            using (MyBankContext myBankContext = new MyBankContext())
            {
                myBankContext.CreditCards.Add(creditCard);
                myBankContext.SaveChanges();
            }
        }

        public bool CardNoIsExists(int no)
        {
            using (MyBankContext myBankContext = new MyBankContext())
            {
                return myBankContext.Set<CreditCard>().Any(c => c.CardNo == no);
            }
        }

        public CreditCard GetByCreditCardId(int customerId)
        {

            using (MyBankContext myBankContext = new MyBankContext())
            {
                var result = myBankContext.CreditCards.Where(c => c.CustomerId == customerId).FirstOrDefault();
                var x = result.CardLimit.Limit;
                result.CardLimit.Limit = x;
                return result;
            }
        }

        public CreditCard GetCreditCardByCardNo(int cardNo)
        {
            using(MyBankContext myBankContext = new MyBankContext())
            {
                var result = myBankContext.CreditCards.Where(c => c.CardNo == cardNo).FirstOrDefault();
                return result;
            }
        }

        public CreditCard LoadDebt(CreditCard creditCard ,int id)
        {
            using (MyBankContext myBankContext = new MyBankContext())
            {
                var result = myBankContext.CreditCards.Where(c => c.CustomerId == id).First();
                result.Debt = creditCard.Debt;
                myBankContext.Entry(result).State = EntityState.Modified;
                myBankContext.SaveChanges();
                return result;
            }
        }

        public void PayCreditCard(AccountInformation accountInformation, int id)
        {
            using (MyBankContext myBankContext = new MyBankContext())
            {
                var result = myBankContext.AccountInformations.Where(a => a.CustomerId == id).First();
                result.Money = accountInformation.Money;
                myBankContext.Entry(result).State = EntityState.Modified;
                myBankContext.SaveChanges();
            }
        }
    }
}
