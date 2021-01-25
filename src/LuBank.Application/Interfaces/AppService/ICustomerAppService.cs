using FluentValidation.Results;
using LuBank.Application.ViewModel;
using LuBank.Application.ViewModel.Customers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LuBank.Application.Interfaces.AppService
{
    public interface ICustomerAppService
    {
        /// <summary>
        /// Consulta Cliente pelo Id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        CustomerViewModel GetById(Guid id);

        ValidationResult Add(CustomerViewModel customer);

        ValidationResult Update(CustomerViewModel customer);
    }
}
