using LuBank.Domain.Interfaces;
using LuBank.Domain.Model.Customers;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LuBank.Infra.Data.Context
{
    /// <summary>
    /// Data context LuBank
    /// </summary>
    public class LuBankDataContext : DbContext, IUnitOfWork
    {
        #region :: DbSets de Entidades

        /// <summary>
        /// DbSet de Clientes
        /// </summary>
        public DbSet<Customer> Customers { get; set; }

        /// <summary>
        /// DbSet de Endereços de clientes
        /// </summary>
        public DbSet<CustomerAddress> CustomerAdresses { get; set; }

        /// <summary>
        /// DbSet de documentos de clientes
        /// </summary>
        public DbSet<CustomerDocument> CustomerDocuments { get; set; }

        /// <summary>
        /// DbSet de Telefones de Cllientes
        /// </summary>
        public DbSet<CustomerPhone> CustomerPhones { get; set; }

        #endregion

        public Task<bool> Commit()
        {
            throw new NotImplementedException();
        }
    }
}
