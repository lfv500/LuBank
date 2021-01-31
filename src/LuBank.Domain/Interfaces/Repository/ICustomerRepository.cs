using LuBank.Domain.Model.Customers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace LuBank.Domain.Interfaces.Repository
{
    /// <summary>
    /// Repositório de Clientes
    /// </summary>
    public interface ICustomerRepository
    {
        /// <summary>
        /// Retorna um cliente pelo Id
        /// </summary>
        public Customer GetById(Guid id);

        /// <summary>
        /// Retorna todos os Clientes cadastrados
        /// </summary>
        /// <returns></returns>
        IEnumerable<Customer> GetAll(Expression<Func<Customer, bool>> predicate);

        /// <summary>
        /// Adiciona um Cliente no banco de dados
        /// </summary>
        public void Add(Customer customer);

        /// <summary>
        /// Atualiza um Cliente no Banco de dados
        /// </summary>
        public void Update(Customer customer);

        /// <summary>
        /// Retorna true se o cliente existir
        /// </summary>
        bool Exists(Guid id);

        /// <summary>
        /// Remove um cliente do banco de dados
        /// </summary>
        void Remove(Guid id);
    }
}
