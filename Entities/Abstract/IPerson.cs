using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Abstract
{
    public interface IPerson
    {
        string Name { get; set; }
        string Surname { get; set; }
        string PhoneNo { get; set; }
    }
}
