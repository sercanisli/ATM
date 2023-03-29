using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess.Abstract;
using DataAccess.Concrete.Context;
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

        public void AddMoney(AccountInformation accountInformation)
        {
            using (MyBankContext myBankContext = new MyBankContext())
            {
                myBankContext.AccountInformations.Add(accountInformation);
                myBankContext.SaveChanges();
            }
        }

        public bool GetCustomer(string customerNo, string customerPassword)
        {
            using (MyBankContext myBankContext = new MyBankContext())
            {
                var result = myBankContext.Set<Customer>()
                    .Any(c => c.CustomerNo == customerNo && c.Password == customerPassword);
                return result;
            }
        }

        public void SubtractMoney(Customer customer)
        {
            throw new NotImplementedException();
        }

        public void Update(Customer customer)
        {
            throw new NotImplementedException();
        }
    }
}
