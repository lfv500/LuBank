using FluentValidation;
using LuBank.Domain.Model.Customers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LuBank.Domain.Validation.Customers
{
    public abstract class CustomerValidation : AbstractValidator<Customer>
    {
        protected void ValidateId()
        {
            RuleFor(e => e.Id)
                .NotEqual(Guid.Empty);
        }

        protected void ValidateName()
        {
            RuleFor(e => e.Name)
                .NotEmpty()
                .MaximumLength(255);
        }

        protected void ValidatePhones()
        {
            RuleFor(e => e.Phones)
                .NotNull()
                .Must(e => e.Any());
        }

        protected void ValidateAddress()
        {
            RuleFor(e => e.Address)
                .NotNull();
        }

        protected void ValidateDocuments()
        {
            RuleFor(e => e.Documents)
                .NotNull()
                .Must(e => e.Any());
        }
    }
}
