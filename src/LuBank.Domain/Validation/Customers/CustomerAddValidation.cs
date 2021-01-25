using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LuBank.Domain.Validation.Customers
{
    public class CustomerAddValidation : CustomerValidation
    {
        public CustomerAddValidation()
        {
            ValidateName();
            ValidateAddress();
            ValidatePhones();
            ValidateDocuments();
        }
    }
}
