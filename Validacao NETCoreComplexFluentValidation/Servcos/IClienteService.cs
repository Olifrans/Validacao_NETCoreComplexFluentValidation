using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Validacao_NETCoreComplexFluentValidation.Models;

namespace Validacao_NETCoreComplexFluentValidation.Servcos
{
    public interface IClienteService
    {
        ClientePega SaveClientePega(ClientePega clientePega);
    }
}
