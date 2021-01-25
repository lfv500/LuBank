using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LuBank.Domain.Validation.Customers
{
    public class CustomerUpdateValidation: CustomerValidation
    {
        public CustomerUpdateValidation()
        {
            ValidateId();
            ValidateName();
            ValidateAddress();
            ValidatePhones();
            ValidateDocuments();
        }
    }
}
