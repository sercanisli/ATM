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
        void Add(Customer customer);
        void Update(Customer customer);
        bool GetCustomer(string customerNo, string customerPassword);
        void AddMoney(AccountInformation accountInformation);
        void SubtractMoney(Customer customer);

    }
}
