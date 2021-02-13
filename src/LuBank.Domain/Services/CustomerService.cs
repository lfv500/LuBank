using FluentValidation.Results;
using LuBank.Domain.Interfaces;
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
        private readonly IUnitOfWork _unitOfWork;

        public CustomerService(ICustomerRepository customerRepository, 
            IUnitOfWork unitOfWork)
        {
            _customerRepository = customerRepository;
            _unitOfWork = unitOfWork;
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
            _unitOfWork.Commit();

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
            _unitOfWork.Commit();
            return result;
        }

        public ValidationResult Update(Customer customer)
        {
            //Validações para Update
            var customerUpddateValidator = new CustomerUpdateValidation();
            var validationResult = customerUpddateValidator.Validate(customer);

            if (!validationResult.IsValid)
                return validationResult;

            var databaseCustomer = _customerRepository.GetById(customer.Id);
            databaseCustomer.Name = customer.Name;
            
            //Realiza alterações no Banco de Dados
            _customerRepository.Update(databaseCustomer);
            _unitOfWork.Commit();
            return validationResult;
        }
    }
}
