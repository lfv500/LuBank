using AutoMapper;
using FluentValidation.Results;
using LuBank.Application.Interfaces.AppService;
using LuBank.Application.ViewModel.Customers;
using LuBank.Domain.Interfaces.Repository;
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
        private readonly ICustomerRepository _customerRepository;
        private readonly IMapper _mapper;

        public CustomerAppService(ICustomerService customerService,
            ICustomerRepository customerRepository,
            IMapper mapper)
        {
            _customerService = customerService;
            _customerRepository = customerRepository;
            _mapper = mapper;
        }

        public ValidationResult Add(CustomerViewModel customerViewModel)
        {
            var customer = _mapper.Map<CustomerViewModel, Customer>(customerViewModel);
            return _customerService.Add(customer);
        }

        public IEnumerable<CustomerViewModel> GetAll()
        {
            var result = _customerRepository.GetAll(null);
            return _mapper.Map<IEnumerable<Customer>, IEnumerable<CustomerViewModel>>(result);
        }

        public IEnumerable<CustomerViewModel> GetAllByName(string name)
        {
            var result = _customerRepository.GetAll(e=> e.Name.Contains(name)); //equivalente a: where c.name like %name%
            return _mapper.Map<IEnumerable<Customer>, IEnumerable<CustomerViewModel>>(result);
        }

        public CustomerViewModel GetById(Guid id)
        {
            var result = _customerRepository.GetById(id);
            return _mapper.Map<Customer, CustomerViewModel>(result);
        }

        public ValidationResult Update(CustomerViewModel customerViewModel)
        {
            var customer = _mapper.Map<CustomerViewModel, Customer>(customerViewModel);
            return _customerService.Update(customer);
        }
    }
}
