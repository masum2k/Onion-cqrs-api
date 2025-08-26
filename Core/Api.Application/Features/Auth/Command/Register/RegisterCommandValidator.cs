using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Api.Application.Features.Auth.Command.Register
{
    public class RegisterCommandValidator : AbstractValidator<RegisterCommandRequest>
    {
        public RegisterCommandValidator()
        {
            RuleFor(x=> x.FullName)
                .NotEmpty().WithMessage("Full name is required.")
                .MaximumLength(50).WithMessage("Full name must not exceed 100 characters.")
                .MinimumLength(2).WithMessage("Full name must be at least 2 characters long.")
                .WithName("Full Name");

            RuleFor(x => x.Email)
                .NotEmpty().WithMessage("Email is required.")
                .EmailAddress().WithMessage("A valid email is required.")
                .MinimumLength(5).WithMessage("Email must be at least 5 characters long.")
                .MaximumLength(60).WithMessage("Email must not exceed 100 characters.")
                .WithName("Email");

            RuleFor(x => x.Password)
                .NotEmpty().WithMessage("Password is required.")
                .MinimumLength(6).WithMessage("Password must be at least 6 characters long.")
                .MaximumLength(20).WithMessage("Password must not exceed 20 characters.")
                .WithName("Password");

            RuleFor(x => x.ConfirmPassword)
                .NotEmpty().WithMessage("Confirm Password is required.")
                .Equal(x => x.Password).WithMessage("Passwords do not match.")
                .WithName("Confirm Password");

        }
    }
}
