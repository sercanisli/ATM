using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using Business.ValidationRules.FluentValidation;
using Business.HashProcess;
using FluentValidation.Results;
using FluentValidation;

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
            customer.Password=Hash.getHashMD5(customer.Password);
            CustomerValidator customerValidator = new CustomerValidator();
            ValidationResult result = customerValidator.Validate(customer);
            foreach(var item in result.Errors)
            {
                throw new ValidationException(result.Errors);
            }

            Random randomCustomerwNo = new Random();
            int no = randomCustomerwNo.Next(10000,99999);
            if(CustomerNoIsExists(no)==false)
            {
                customer.CustomerNo = no;
                _customerDal.Add(customer);
            }
            else
            {
                no = randomCustomerwNo.Next(10000, 99999);
            }
        }

        public void AddMoneyProcess(AccountInformation accountInformation)
        {

            _customerDal.AddMoneyProcess(accountInformation);
        }

        public void CreateAccount(AccountInformation accountInformation)
        {
            _customerDal.CreateAccount(accountInformation);
        }
        public bool CustomerNoIsExists(int no)
        {
            return _customerDal.CustomerNoIsExists(no);
        }

        public void DrawMoney(AccountInformation accountInformation, int id)
        {
            var result = GetMoneyById(id);
            decimal money = result.Money;
            money = money - accountInformation.Money;
            accountInformation.Money = money;
            _customerDal.DrawMoney(accountInformation, id);
        }

        public AccountInformation GetAccountByCustomerNo(int customerNo)
        {
            return _customerDal.GetAccountByCustomerNo(customerNo);
        }

        public bool GetCustomer(int customerNo, string customerPassword)
        {
            IdentityValidator customerValidator = new IdentityValidator();

            customerPassword = Hash.getHashMD5(customerPassword);

            Customer customer = new Customer()
            {
                CustomerNo=customerNo,
                Password=customerPassword
            };
            ValidationResult validationResult = customerValidator.Validate(customer);
            var result =_customerDal.GetCustomer(customer);
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

        public void TransferMoney(AccountInformation accountInformation, int customerNo, int id)
        {
            decimal money = 0;
            var result = GetMoneyById(id);
            var account = GetAccountByCustomerNo(customerNo);
            account.Money = account.Money + accountInformation.Money;
            result.Money = result.Money - accountInformation.Money;

            money = account.Money;
            accountInformation.Money = result.Money;
            _customerDal.TransferMoney(accountInformation, customerNo, id, money);
        }
        public void UpdateMoneyProcess(AccountInformation accountInformation, int customerId)
        {
            var result = GetMoneyById(customerId);
            decimal money = result.Money;
            money = money + accountInformation.Money;
            accountInformation.Money = money;
            _customerDal.UpdateMoneyProcess(accountInformation,customerId);
        }
    }
}
