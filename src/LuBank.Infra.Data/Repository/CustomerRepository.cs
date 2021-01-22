using LuBank.Domain.Interfaces.Repository;
using LuBank.Domain.Model.Customers;
using LuBank.Infra.Data.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace LuBank.Infra.Data.Repository
{
    public class CustomerRepository : ICustomerRepository, IDisposable
    {
        private readonly LuBankDataContext Db;

        public CustomerRepository(LuBankDataContext context)
        {
            Db = context;
        }

        public void Add(Customer customer)
        {
            Db.Customers.Add(customer);
        }

        public IEnumerable<Customer> GetAll(Expression<Func<Customer, bool>> predicate)
        {
            return Db.Customers
                .Where(predicate)
                .ToList();
        }

        public Customer GetById(Guid id)
        {
            return Db.Customers
                .FirstOrDefault(e => e.Id == id);
        }

        public void Update(Customer customer)
        {
            Db.Customers
                .Update(customer);
        }

        public void Dispose()
        {
            Db.Dispose();
        }
    }
}
