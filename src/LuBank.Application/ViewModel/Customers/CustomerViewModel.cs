using LuBank.Application.Enum.Customers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LuBank.Application.ViewModel.Customers
{
    public class CustomerViewModel
    {
        public Guid Id { get; set; }

        public string Name { get; set; }

        public Guid AddressId { get; set; }

        public virtual CustomerAddressViewModel Address { get; set; }

        public virtual ICollection<CustomerPhoneViewModel> Phones { get; set; }

        public virtual ICollection<CustomerDocumentViewModel> Documents { get; set; }

    }
}
