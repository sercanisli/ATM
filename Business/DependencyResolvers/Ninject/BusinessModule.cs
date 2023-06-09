﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.Abstract;
using Business.Concrete;
using DataAccess.Abstract;
using DataAccess.Concrete;
using DataAccess.Concrete.EntityFramework;
using Ninject.Modules;

namespace Business.DependencyResolvers.Ninject
{
    public class BusinessModule :NinjectModule
    {
        public override void Load()
        {
            Bind<ICustomerDal>().To<EfCustomerDal>().InSingletonScope();
            Bind<ICustomerService>().To<CustomerManager>().InSingletonScope();

            Bind<IBillDal>().To<EfBillDal>().InSingletonScope();
            Bind<IBillService>().To<BillManager>().InSingletonScope();

            Bind<ICardLimitDal>().To<EfCardLimitDal>().InSingletonScope();
            Bind<ICardLimitService>().To<CardLimitManager>().InSingletonScope();

            Bind<ICreditCardDal>().To<EfCreditCardDal>().InSingletonScope();
            Bind<ICreditCardService>().To<CreditCardManager>().InSingletonScope();

            Bind<INonCustomerDal>().To<EfNonCustomerDal>().InSingletonScope();
            Bind<INonCustomerService>().To<NonCustomerManager>().InSingletonScope();
        }
    }
}
