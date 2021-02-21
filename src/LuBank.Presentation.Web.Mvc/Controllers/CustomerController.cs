using AutoMapper;
using LuBank.Application.Interfaces.AppService;
using LuBank.Application.ViewModel.Customers;
using LuBank.Domain.Interfaces.Repository;
using LuBank.Domain.Interfaces.Services;
using LuBank.Domain.Model.Customers;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LuBank.Presentation.Web.Mvc.Controllers
{
    public class CustomerController : Controller
    {
        private readonly ICustomerAppService _customerAppService;

        public CustomerController(ICustomerAppService customerAppService)
        {
            _customerAppService = customerAppService;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult New()
        {
            return View();
        }

        public IActionResult Search()
        {
            var customers = _customerAppService.GetAll();
            return View(customers);
        }
    }
}
