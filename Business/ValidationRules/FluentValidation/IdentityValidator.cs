using Entities.Concrete;
using FluentValidation;
using FluentValidation.Results;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Business.ValidationRules.FluentValidation
{
    public class IdentityValidator : AbstractValidator<Customer>
    {
        public IdentityValidator()
        {
            RuleFor(c => c.CustomerNo).NotEmpty().WithMessage("Customer No is not empty");
            RuleFor(c=>c.CustomerNo.ToString())
                .Must(IsCustomerNoValid).WithMessage("Only numbers can be entered for the customer number.");


            RuleFor(c => c.Password).NotEmpty().WithMessage("Password is not empty");




            bool IsCustomerNoValid(string arg)
            {
                Regex regex = new Regex(@"[0-9]{5}$");
                return regex.IsMatch(arg);
            }

        }
    }
}
