﻿using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface ICustomerService
    {
        void Add(Customer customer);
        bool GetCustomer(int customerNo, string customerPassword);
        void AddMoneyProcess(AccountInformation accountInformation);
        Customer GetCustomerById(int customerNo);
        void UpdateMoneyProcess(AccountInformation accountInformation, int customerId);
        bool IsExistsForMoneyProcess(int customerId);
        AccountInformation GetMoneyById(int id);
        void DrawMoney(AccountInformation accountInformation, int id);
        void TransferMoney(AccountInformation accountInformation, int CustomerNo, int id);
        void CreateAccount(AccountInformation accountInformation);
        AccountInformation GetAccountByCustomerNo(int customerNo);
    }
}
