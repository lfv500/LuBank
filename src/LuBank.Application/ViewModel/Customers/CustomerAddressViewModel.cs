using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LuBank.Application.ViewModel.Customers
{
    public class CustomerAddressViewModel
    {
        public Guid Id { get; set; }

        public string Street { get; set; }

        public int Number { get; set; }

        public string Neighborhood { get; set; }
        public string City { get; set; }
        public string Province { get; set; }

        public string ZipCode { get; set; }

        public string Complement { get; set; }
    }
}
