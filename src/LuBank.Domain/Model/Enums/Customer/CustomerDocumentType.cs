using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LuBank.Domain.Model.Enums.Customer
{
    public enum CustomerDocumentType : int
    {
        Unknown = 0,
        Cpf = 1,
        Rg = 2,
        Cnpj = 3,
        GreenCard = 4,
        Rne = 5
    }
}
