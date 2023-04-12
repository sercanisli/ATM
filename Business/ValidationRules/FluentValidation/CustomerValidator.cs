using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Business.ValidationRules.FluentValidation
{
    public class CustomerValidator : AbstractValidator<Customer>
    {
        public CustomerValidator()
        {
            RuleFor(c => c.Email).NotEmpty().WithMessage("Email is not empty")
                .EmailAddress().WithMessage("Email must conform to email format")
                .Must(IsEmailValid).WithMessage("E-mail must conform to e-mail format");

            RuleFor(c => c.Password).NotEmpty().WithMessage("Password is not empty")
                .Must(IsPasswordValid).WithMessage("Password must contain at least one number and at least one letter");

            //RuleFor(c => c.BirthDay).NotEmpty().WithMessage("Birthday is not empty")
            //    .GreaterThan(DateTime.Now.AddYears(-18)).WithMessage("You must be over 18 years old");

            //RuleFor(c => c.Gender).NotEmpty().WithMessage("Gender is not empty")
            //    .IsInEnum().WithMessage("Invalid gender selection");

            RuleFor(c => c.Name).NotEmpty().WithMessage("Name is not empty")
                .MaximumLength(25).WithMessage("Name cannot be longer than 25 characters")
                .MinimumLength(2).WithMessage("Name must be longer than 2 characters");

            RuleFor(c => c.Surname).NotEmpty().WithMessage("Surname is not empty")
                .MaximumLength(25).WithMessage("Surname cannot be longer than 25 characters")
                .MinimumLength(2).WithMessage("Surname must be longer than 2 characters");

            RuleFor(c => c.PhoneNo).NotEmpty().WithMessage("Phone Number is not empty")
                .Matches(@"^\d{11}$").WithMessage("Invalid phone number format. (Ex: 05551234567)");



            bool IsPasswordValid(string arg)
            {
                Regex regex = new Regex(@"^(?=.*[A-Za-z])(?=.*\d)[A-Za-z\d]{8,}$");
                return regex.IsMatch(arg);
            }
            bool IsEmailValid(string arg)
            {
                Regex regex = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
                return regex.IsMatch(arg);
            }
        }
    }
}
