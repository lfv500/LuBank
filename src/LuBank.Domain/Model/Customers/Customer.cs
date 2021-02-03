using LuBank.Domain.Model.Enums.Customer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LuBank.Domain.Model.Customers
{
    public class Customer: Entity
    {
        public string Name { get; set; }

        public Guid AddressId { get; set; }

        public CustomerAddress Address { get; set; }

        public ICollection<CustomerPhone> Phones { get; set; }

        public ICollection<CustomerDocument> Documents { get; set; }
    }
}