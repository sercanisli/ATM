using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Abstract
{
    public interface ICustomerDal
    {
        bool CustomerNoIsExists(int no);
        void Add(Customer customer);
        bool GetCustomer(Customer customer);
        void AddMoneyProcess(AccountInformation accountInformation);
        Customer GetCustomerById(int customerNo);
        void UpdateMoneyProcess(AccountInformation accountInformation, int customerId);
        bool IsExistsForMoneyProcess(int customerId);
        AccountInformation GetMoneyById(int id);
        void DrawMoney(AccountInformation accountInformation, int id);
        void TransferMoney(AccountInformation accountInformation, int CustomerNo, int id, decimal money);
        void CreateAccount(AccountInformation accountInformation);
        AccountInformation GetAccountByCustomerNo(int customerNo);


    }
}
