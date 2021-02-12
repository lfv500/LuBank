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

            RuleFor(e => e.Phones)
                .ForEach(e =>
                {
                    e.ChildRules(z =>
                    {
                        z.RuleFor(a => a.Area)
                            .GreaterThan(0);

                        z.RuleFor(a => a.Ddd)
                            .GreaterThan(0);

                        z.RuleFor(a => a.Number)
                            .NotEmpty();
                    });
                });
        }

        protected void ValidateAddress()
        {
            RuleFor(e => e.Address)
                .NotNull();

            RuleFor(e => e.Address)
                .ChildRules(a => 
                {
                    a.RuleFor(p => p.Street)
                        .NotEmpty()
                        .MaximumLength(255);

                    a.RuleFor(p => p.Province)
                        .NotEmpty()
                        .MaximumLength(255);

                    a.RuleFor(p => p.Neighborhood)
                        .NotEmpty()
                        .MaximumLength(255);

                    a.RuleFor(p => p.City)
                        .NotEmpty()
                        .MaximumLength(255);

                    a.RuleFor(p => p.Number)
                        .GreaterThan(0);

                    a.RuleFor(p => p.ZipCode)
                        .NotEmpty()
                        .MaximumLength(50);
                });
        }

        protected void ValidateDocuments()
        {
            RuleFor(e => e.Documents)
                .NotNull()
                .Must(e => e.Any());

            RuleFor(e => e.Documents)
                .ForEach(e =>
                {
                    e.ChildRules(z =>
                    {
                        z.RuleFor(a => a.Value)
                            .NotEmpty()
                            .IsValidCPF()
                            .When(e => e.Type == Model.Enums.Customer.CustomerDocumentType.Cpf)
                            .IsValidCNPJ()
                            .When(e => e.Type == Model.Enums.Customer.CustomerDocumentType.Cnpj);
                    });
                });
        }
    }
}
