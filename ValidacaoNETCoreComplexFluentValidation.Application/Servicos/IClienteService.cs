using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ValidacaoNETCoreComplexFluentValidation.Domain.Models;

namespace ValidacaoNETCoreComplexFluentValidation.Application.Servicos
{
    public interface IClienteService
    {
        ClientePega SaveClientePega(ClientePega clientePega);
    }
}
