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
    public class EfNonCustomerDal : INonCustomerDal
    {
        public void AddNonCustomer(NonCustomer nonCustomer)
        {
            using (MyBankContext myBankContext = new MyBankContext())
            {
                myBankContext.NonCustomers.Add(nonCustomer);
                myBankContext.SaveChanges();
            }
        }

        public bool IsItOurCard(int cardNo)
        {
            using(MyBankContext myBankContext = new MyBankContext())
            {
                var result = myBankContext.Set<CreditCard>().Any(c => c.CardNo == cardNo);
                return result;
            }
        }

        public bool IsItOurCustomer(int customerNo)
        {
            using (MyBankContext myBankContext = new MyBankContext())
            {
                var result = myBankContext.Set<Customer>().Any(c => c.CustomerNo == customerNo);
                return result;
            }
        }

        public void PayCreditCard(CreditCard creditCard, int cardNo, decimal debt)
        {
            using (MyBankContext myBankContext = new MyBankContext())
            {
                var result = myBankContext.CreditCards.Where(c => c.CardNo == cardNo).FirstOrDefault();
                result.Debt = debt;
                myBankContext.Entry(result).State = EntityState.Modified;
                myBankContext.SaveChanges();
            }
        }

        public void TransferMoney(AccountInformation accountInformation, int customerNo)
        {
            using (MyBankContext myBankContext = new MyBankContext())
            {
                var result = myBankContext.AccountInformations.Where(a => a.CustomerNo == customerNo).FirstOrDefault();
                result.Money = result.Money + accountInformation.Money;
                myBankContext.Entry(result).State = EntityState.Modified;
                myBankContext.SaveChanges();
            }
        }
    }
}
