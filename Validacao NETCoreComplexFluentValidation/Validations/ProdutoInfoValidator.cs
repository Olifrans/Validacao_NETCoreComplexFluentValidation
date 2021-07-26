using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Validacao_NETCoreComplexFluentValidation.Models;

namespace Validacao_NETCoreComplexFluentValidation.Validations
{
    public class ProdutoInfoValidator : AbstractValidator<ClienteInfo>
    {
        public ProdutoInfoValidator()
        {
            RuleFor(p => p.ClienteNome).NotEmpty().NotNull().MaximumLength(50);
            RuleFor(p => p.ClienteDataCadastro).Must(IsTestDataValid).WithMessage("Test date must be in the future");
                
        }

        private bool IsTestDataValid(DateTime testDate)
        {
            return testDate.Date > DateTime.Now.Date;
        }
    }
}
