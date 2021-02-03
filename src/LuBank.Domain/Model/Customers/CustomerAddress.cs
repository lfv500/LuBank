using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LuBank.Domain.Model.Customers
{
    public class CustomerAddress : Entity
    {
        public string Street { get; set; }

        public int Number { get; set; }

        public string Neighborhood { get; set; }
        public string City { get; set; }
        public string Province { get; set; }

        public string ZipCode { get; set; }

        public string Complement { get; set; }
    }
}
