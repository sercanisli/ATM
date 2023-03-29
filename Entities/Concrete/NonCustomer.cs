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
        public string Name { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string Surname { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string PhoneNo { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string IdentityNo { get; set; }

    }
}
