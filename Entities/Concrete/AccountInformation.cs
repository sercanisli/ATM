using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities.Abstract;

namespace Entities.Concrete
{
    public class AccountInformation:Base<int>
    {
        public decimal Money { get; set; }
        public int CustomerId { get; set; }
        public int CustomerNo { get; set; }




        [ForeignKey("CustomerId")]
        public virtual Customer Customer { get; set; }
    }
}
