using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.Context
{
    public class MyBankContext
        : DbContext
    {
        public MyBankContext():base("name=mycon")
        {
            
        }
        public DbSet<Bill> Bills { get; set; }
        public DbSet<AccountInformation> AccountInformations { get; set; }
        public DbSet<BillType> BillTypes { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<NonCustomer> NonCustomers { get; set; }

    }
}
