using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities.Abstract;

namespace Entities.Concrete
{
    public class NonCustomer : Base<int>, IPerson
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string PhoneNo { get; set; }
        public string IdentityNo { get; set; }
        public decimal Amount { get; set; }

    }
}
