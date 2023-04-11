using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.ValidationRules.FluentValidation
{
    public class CustomerValidator : AbstractValidator<Customer>
    {
        public CustomerValidator()
        {
            RuleFor(c => c.Email).NotEmpty().WithMessage("Email is not empty");
            RuleFor(c => c.Password).NotEmpty().WithMessage("Password is not empty");
            RuleFor(c => c.BirthDay).NotEmpty().WithMessage("Birthday is not empty");
            RuleFor(c => c.Gender).NotEmpty().WithMessage("Gender is not empty");
            RuleFor(c => c.Name).NotEmpty().WithMessage("Name is not empty");
            RuleFor(c => c.Surname).NotEmpty().WithMessage("Surname is not empty");
            RuleFor(c => c.PhoneNo).NotEmpty().WithMessage("Phone Number is not empty");

        }
    }
}
