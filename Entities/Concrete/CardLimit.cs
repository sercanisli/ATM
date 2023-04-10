using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class CardLimit
    {
        public byte Id { get; set; }
        public decimal Limit { get; set; }


        public override string ToString()
        {
            return $"{Limit}";
        }
    }
}
