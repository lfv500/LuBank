using LuBank.Domain.Interfaces;
using LuBank.Domain.Model.Customers;
using LuBank.Infra.Data.EntityConfig.Customers;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.IO;
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

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new CustomerConfig());

            base.OnModelCreating(modelBuilder);
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var config = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();

            optionsBuilder.UseSqlServer(config.GetConnectionString("DefaultConnection"));
        }

        public Task<bool> Commit()
        {
            throw new NotImplementedException();
        }
    }
}
