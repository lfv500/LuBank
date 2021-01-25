using FluentValidation.Results;
using LuBank.Application.Interfaces.AppService;
using LuBank.Application.ViewModel.Customers;
using LuBank.Domain.Interfaces.Services;
using LuBank.Domain.Model.Customers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LuBank.Application.AppService
{
    public class CustomerAppService : ICustomerAppService
    {
        private readonly ICustomerService _customerService;

        public CustomerAppService(ICustomerService customerService)
        {
            _customerService = customerService;
        }

        public ValidationResult Add(CustomerViewModel customer)
        {
            //TODO: implementar auto mapper
            var customerModel = new Customer();
            customerModel.Id = customer.Id;
            customerModel.Name = customer.Name;
            customerModel.Address = new CustomerAddress();
            customerModel.Address.Id = customer.Address.Id;
            

            return _customerService.Add(customerModel);
        }

        public IEnumerable<CustomerViewModel> GetAll()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<CustomerViewModel> GetAllByName(string name)
        {
            throw new NotImplementedException();
        }

        public CustomerViewModel GetById(Guid id)
        {
            throw new NotImplementedException();
        }

        public ValidationResult Update(CustomerViewModel customer)
        {
            throw new NotImplementedException();
        }
    }
}
