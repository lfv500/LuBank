using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LuBank.Domain.Model.Customers
{
    public class CustomerPhone : Entity
    {
        public Guid CustomerId { get; set; }

        public int Ddd { get; set; }

        public int Area { get; set; }

        public string Number { get; set; }
    }
}
