using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LuBank.Domain.Model.Customers
{
    public class CustomerDocument
    {
        public Guid Guid { get; set; }

        public Guid CustomerId { get; set; }

        public string Value { get; set; }
    }
}
