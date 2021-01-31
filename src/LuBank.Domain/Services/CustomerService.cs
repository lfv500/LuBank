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
        private readonly ICustomerRepository _customerRepository;

        public CustomerService(ICustomerRepository custtomerRepository)
        {
            _customerRepository = custtomerRepository;
        }

        public ValidationResult Add(Customer customer)
        {
            //Validações para Add
            var customerAddValidator = new CustomerAddValidation();
            var validationResult = customerAddValidator.Validate(customer);

            if (!validationResult.IsValid)
                return validationResult;

            //Incluir no Banco de Dados
            _customerRepository.Add(customer);
            return validationResult;
        }

        public ValidationResult Remove(Guid id)
        {
            var result = new ValidationResult();

            if (!_customerRepository.Exists(id))
            {
                result.Errors.Add(new ValidationFailure("id", "Cliente inexistente"));
                return result;
            }

            _customerRepository.Remove(id);
            return result;
        }

        public ValidationResult Update(Customer customer)
        {
            //Validações para Update
            var customerUpddateValidator = new CustomerUpdateValidation();
            var validationResult = customerUpddateValidator.Validate(customer);

            if (!validationResult.IsValid)
                return validationResult;

            //Realiza alterações no Banco de Dados
            _customerRepository.Update(customer);
            return validationResult;
        }
    }
}
