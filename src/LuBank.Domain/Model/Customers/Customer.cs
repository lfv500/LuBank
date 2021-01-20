using LuBank.Domain.Model.Enums.Customer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LuBank.Domain.Model.Customers
{
    public class Customer
    {
        public Guid Id { get; set; }

        public string Name { get; set; }

        public Guid AddressId { get; set; }

        public CustomerDocumentType Type { get; set; }

        public virtual CustomerAddress Address { get; set; }

        public virtual ICollection<CustomerPhone> Phones { get; set; }

        public virtual ICollection<CustomerDocuments> Documents { get; set; }
    }
}