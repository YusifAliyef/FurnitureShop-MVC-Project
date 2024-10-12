using FluentValidation;
using Fs.BusinessLogicLayer.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fs.BusinessLogicLayer.ValidationRules
{
    public class CreateUserDtoValidator: AbstractValidator<CreateUserDto>
    {
        public CreateUserDtoValidator()
        {
            RuleFor(x => x.Email)
                .NotEmpty()
                .WithMessage("Email is required");

            RuleFor(x => x.Email)
                .EmailAddress()
                .WithMessage("Email is in incorrect format");

            RuleFor(x => x.FirstName)
                .NotEmpty()
                .WithMessage("First Name is required");

            RuleFor(x => x.LastName)
                .NotEmpty()
                .WithMessage("Last Name is required");

            RuleFor(x => x.Password)
                .NotEmpty()
                .WithMessage("Password is required");
        }

    }
}
