using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LuBank.Application.ViewModel.Customers
{
    public class CustomerPhoneViewModel
    {
        public Guid Id { get; set; }

        public Guid CustomerId { get; set; }

        public int Ddd { get; set; }

        public int Area { get; set; }

        public string Number { get; set; }

        public override string ToString()
            => $"+{Area} ({Ddd}) {Number}";
    }
}
