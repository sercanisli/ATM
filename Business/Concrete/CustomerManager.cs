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
            customer.CustomerNo = no;


            _customerDal.Add(customer);
        }

        public void AddMoneyProcess(AccountInformation accountInformation)
        {
            _customerDal.AddMoneyProcess(accountInformation);
        }

        public void DrawMoney(AccountInformation accountInformation, int id)
        {
            _customerDal.DrawMoney(accountInformation, id);
        }

        public bool GetCustomer(int customerNo, string customerPassword)
        {
            var result=_customerDal.GetCustomer(customerNo, customerPassword);
            return result;
        }

        public Customer GetCustomerById(int customerNo)
        {
            return _customerDal.GetCustomerById(customerNo);
            
        }

        public AccountInformation GetMoneyById(int id)
        {
            return _customerDal.GetMoneyById(id);
        }

        public bool IsExistsForMoneyProcess(int customerId)
        {
            return _customerDal.IsExistsForMoneyProcess(customerId);
        }

        public void TransferMoney(AccountInformation accountInformation, int CustomerNo, int id)
        {
            _customerDal.TransferMoney(accountInformation, CustomerNo, id);
        }
        public void UpdateMoneyProcess(AccountInformation accountInformation, int customerId)
        {
            _customerDal.UpdateMoneyProcess(accountInformation,customerId);
        }
    }
}
