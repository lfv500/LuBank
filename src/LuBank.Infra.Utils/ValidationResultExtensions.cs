using FluentValidation.Results;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LuBank.Infra.Utils
{
    public static class ValidationResultExtensions
    {
        /// <summary>
        /// Obtém uma mensagem única dos erros
        /// </summary>
        public static string GetErrorMessage(this ValidationResult source)
            => source.IsValid
                ? string.Empty
                : string.Join("\n", source.Errors.Select(e => e.ErrorMessage));

    }
}
