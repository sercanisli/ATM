using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities.Abstract;

namespace Entities.Concrete
{
    public class Customer : Base<int>, IPerson
    {
        public string Email { get; set; }
        public string Password { get; set; }
        public int CustomerNo { get; set; }
        public DateTime BirthDay { get; set; }
        public Gender Gender { get; set; }



        public string Name { get; set; }
        public string Surname { get; set; }
        public string PhoneNo { get; set; }
    }

    public enum Gender
    {
        Woman=0,
        Man=1
    }
}
