﻿using LuBank.Domain.Model.Customers;
using System;
using System.Collections.Generic;
using System.Linq;
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
        public IEnumerable<Customer> GetAll();
        
        /// <summary>
        /// Adiciona um Cliente no banco de dados
        /// </summary>
        public void Add(Customer customer);

        /// <summary>
        /// Atualiza um Cliente no Banco de dados
        /// </summary>
        public void Update(Customer customer);
    }
}
