using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ValidacaoNETCoreComplexFluentValidation.Domain.Models
{
    public class ClienteInfo
    {
        public string ClienteNome { get; set; }
        public DateTime ClienteDataCadastro { get; set; }
        public string ClienteDescricao { get; set; }
    }
}
