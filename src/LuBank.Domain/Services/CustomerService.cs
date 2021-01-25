using FluentValidation.Results;
using LuBank.Domain.Interfaces.Repository;
using LuBank.Domain.Interfaces.Services;
using LuBank.Domain.Model.Customers;
using LuBank.Domain.Validation.Customers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LuBank.Domain.Services
{
    public class CustomerService : ICustomerService
    {
        private readonly ICustomerRepository _custtomerRepository;

        public CustomerService(ICustomerRepository custtomerRepository)
        {
            _custtomerRepository = custtomerRepository;
        }

        public ValidationResult Add(Customer customer)
        {
            //Validações para Add
            var customerAddValidator = new CustomerAddValidation();
            var validationResult = customerAddValidator.Validate(customer);

            if (!validationResult.IsValid)
                return validationResult;

            //Incluir no Banco de Dados
            _custtomerRepository.Add(customer);
            return validationResult;
        }

        public ValidationResult Update(Customer customer)
        {
            //Validações para Update
            var customerUpddateValidator = new CustomerUpdateValidation();
            var validationResult = customerUpddateValidator.Validate(customer);

            if (!validationResult.IsValid)
                return validationResult;

            //Realiza alterações no Banco de Dados
            _custtomerRepository.Update(customer);
            return validationResult;
        }
    }
}
