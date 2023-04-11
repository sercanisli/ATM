using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class CreditCard : Base<int>
    {
        public int CustomerId { get; set; }
        public int CardNo { get; set; }
        public decimal Debt { get; set; }
        public byte CardLimitId { get; set; }


        [ForeignKey("CustomerId")]
        public virtual Customer Customer { get; set; }

        [ForeignKey("CardLimitId")]
        public virtual CardLimit CardLimit { get; set; }
    }
}
