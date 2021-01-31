using LuBank.Application.Interfaces.AppService;
using LuBank.Application.ViewModel.Customers;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LuBank.Api.Controllers
{

    public class CustomerController : BaseApiController
    {
        private readonly ICustomerAppService _customerAppService;

        public CustomerController(ICustomerAppService customerAppService)
        {
            _customerAppService = customerAppService;
        }

        [HttpGet]
        [Route("v1/customer/{id}")]
        public IActionResult GetById(Guid id)
        {
            var customerViewModel = _customerAppService.GetById(id);

            return customerViewModel == null
                ? NoContent()
                : Ok(customerViewModel);
        }

        [HttpGet]
        [Route("v1/customer")]
        public IActionResult ListAll()
        {
            var result = _customerAppService.GetAll();

            return result == null
                ? NoContent()
                : Ok(result);
        }

        [HttpPost]
        [Route("v1/customer")]
        public IActionResult Add(CustomerViewModel customer)
        {
            var result = _customerAppService.Add(customer);
            return Ok(result);
        }

        [HttpPut]
        [Route("v1/customer/{id}")]
        public IActionResult Update(CustomerViewModel customer)
        {
            var result = _customerAppService.Update(customer);
            return Ok(result);
        }

        [HttpDelete]
        [Route("v1/customer/{id}")]
        public IActionResult Remove(Guid id)
        {
            var result = _customerAppService.Remove(id);
            return Ok(result);
        }
    }
}
