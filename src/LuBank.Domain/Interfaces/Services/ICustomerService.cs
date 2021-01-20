using LuBank.Domain.Model.Customers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LuBank.Domain.Interfaces.Services
{
    /// <summary>
    /// Serviço de Cliente
    /// </summary>
    public interface ICustomerService
    {
        /// <summary>
        /// Cria um cliente no sistema
        /// </summary>
        public void Add(Customer customer);

        /// <summary>
        /// Realiza alteração em um cliente
        /// </summary>
        /// <param name="customer"></param>
        public void Update(Customer customer);
    }
}
