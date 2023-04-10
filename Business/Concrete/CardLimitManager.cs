using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class CardLimitManager : ICardLimitService
    {
        private ICardLimitDal _cardLimitDal;
        public CardLimitManager(ICardLimitDal cardLimitDal)
        {
            _cardLimitDal = cardLimitDal;
        }
        public List<CardLimit> GetCardLimitItem()
        {
            return _cardLimitDal.GetCardLimitItem();
        }
    }
}
