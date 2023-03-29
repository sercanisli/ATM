using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;

namespace Business.Concrete
{
    public class CustomerManager : ICustomerService
    {
        private ICustomerDal _customerDal ;

        public CustomerManager(ICustomerDal customerDal)
        {
            _customerDal = customerDal;
        }
        public void Add(Customer customer)
        {
            Random randomCustomerwNo = new Random();
            int no = randomCustomerwNo.Next(10000,99999);
            customer.CustomerNo = no.ToString();


            _customerDal.Add(customer);
        }

        public void AddMoney(AccountInformation accountInformation)
        {
            _customerDal.AddMoney(accountInformation);
        }

        public bool GetCustomer(string customerNo, string customerPassword)
        {
            var result=_customerDal.GetCustomer(customerNo, customerPassword);
            return result;
        }

        public void SubtractMoney(Customer customer)
        {
           _customerDal.SubtractMoney(customer);
        }

        public void Update(Customer customer)
        {
            throw new NotImplementedException();
        }
    }
}
