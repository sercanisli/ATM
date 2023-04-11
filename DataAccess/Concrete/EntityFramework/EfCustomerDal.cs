using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess.Abstract;
using DataAccess.Concrete.Context;
using Entities.Abstract;
using Entities.Concrete;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfCustomerDal : ICustomerDal
    {
        public void Add(Customer customer)
        {
            using (MyBankContext myBankContext=new MyBankContext())
            {
                myBankContext.Customers.Add(customer);
                myBankContext.SaveChanges();
            }
        }

        public void AddMoneyProcess(AccountInformation accountInformation)
        {
            using (MyBankContext myBankContext = new MyBankContext())
            {
                myBankContext.AccountInformations.Add(accountInformation);
                myBankContext.SaveChanges();
            }
        }

        public void CreateAccount(AccountInformation accountInformation)
        {
            using (MyBankContext myBankContext = new MyBankContext())
            {
                myBankContext.AccountInformations.Add(accountInformation);
                myBankContext.SaveChanges();
            }
        }

        public bool CustomerNoIsExists(int no)
        {
            using(MyBankContext myBankContext = new MyBankContext())
            {
                return myBankContext.Set<Customer>().Any(c => c.CustomerNo == no);
            }
        }

        public void DrawMoney(AccountInformation accountInformation, int id)
        {
            using (MyBankContext myBankContext = new MyBankContext())
            {

                var result = myBankContext.AccountInformations.Where(a => a.CustomerId == id).First();
                result.Money =result.Money-accountInformation.Money;
                myBankContext.Entry(result).State = EntityState.Modified;
                myBankContext.SaveChanges();
            }
        }

        public bool GetCustomer(int customerNo, string customerPassword)
        {
            using (MyBankContext myBankContext = new MyBankContext())
            {
                var result = myBankContext.Set<Customer>()
                    .Any(c => c.CustomerNo == customerNo && c.Password == customerPassword);
                return result;
            }
        }

        public Customer GetCustomerById(int customerNo)
        {
            using (MyBankContext myBankContext = new MyBankContext())
            {
                var result = myBankContext.Customers.Where(c => c.CustomerNo == customerNo).FirstOrDefault();
                return result;
            }
        }

        public AccountInformation GetMoneyById(int id)
        {
            using(MyBankContext myBankContext = new MyBankContext())
            {
                var result = myBankContext.AccountInformations.Where(a => a.CustomerId == id).FirstOrDefault();
                return result;
            }
        }

        public bool IsExistsForMoneyProcess(int customerId)
        {
            using (MyBankContext myBankContext = new MyBankContext())
            {
                var result = myBankContext.Set<AccountInformation>().Any(a => a.CustomerId == customerId);
                return result;
            }
        }

        public void TransferMoney(AccountInformation accountInformation, int CustomerNo, int id)
        {
            using (MyBankContext myBankContext = new MyBankContext())
            {
                var result = myBankContext.AccountInformations.Where(a => a.CustomerNo == CustomerNo).FirstOrDefault();
                var user = myBankContext.AccountInformations.Where(a => a.CustomerId == id).FirstOrDefault();

                result.Money = result.Money + accountInformation.Money;
                user.Money = user.Money - accountInformation.Money;

                myBankContext.Entry(result).State = EntityState.Modified;
                myBankContext.SaveChanges();
            }
        }

        public void UpdateMoneyProcess(AccountInformation accountInformation, int customerId)
        {
            using (MyBankContext myBankContext = new MyBankContext())
            {
                var result = myBankContext.AccountInformations.Where(a=>a.CustomerId == customerId).First();
                result.Money = accountInformation.Money + result.Money;
                myBankContext.Entry(result).State = EntityState.Modified;
                myBankContext.SaveChanges();
            }
        }
    }
}
