using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Validacao_NETCoreComplexFluentValidation.Models;

namespace Validacao_NETCoreComplexFluentValidation.Validations
{
    public class ClientePegaValidator :  AbstractValidator<ClientePega>
    {
        public ClientePegaValidator()
        {
            RuleFor(p => p.PrimeiroNome).NotEmpty().NotNull().MaximumLength(25);
            RuleFor(p => p.SegundoNome).NotEmpty().NotNull().MaximumLength(25);
            RuleFor(p => p.DataNascimento).Must(IsOver18).WithMessage("Minimum age is 18 for registration");

        }

        private bool IsOver18(DateTime dob)
        {
            return DateTime.Now.Year - dob.Year >= 18;
        }
    }
}
