using LuBank.Application.Enum.Customers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LuBank.Application.ViewModel.Customers
{
    public class CustomerDocumentViewModel
    {
        public Guid Id { get; set; }

        public Guid CustomerId { get; set; }

        public string Value { get; set; }

        public CustomerDocumentType Type { get; set; }

        public override string ToString()
            => $"{Type}: {Value}"; //string.Format("{0}: {1}", Type, Value); //Type + ": " + Value;
    }
}
