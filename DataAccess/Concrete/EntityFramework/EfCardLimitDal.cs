using DataAccess.Abstract;
using DataAccess.Concrete.Context;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfCardLimitDal : ICardLimitDal
    {
        public List<CardLimit> GetCardLimitItem()
        {
            using (MyBankContext myBankContext = new MyBankContext())
            {
                var result = myBankContext.Set<CardLimit>().ToList();
                return result;
            }
        }
    }
}
