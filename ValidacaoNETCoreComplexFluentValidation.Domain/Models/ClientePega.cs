using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ValidacaoNETCoreComplexFluentValidation.Domain.Models
{
    public class ClientePega
    {
        public string PrimeiroNome { get; set; }
        public string SegundoNome { get; set; }
        public DateTime DataNascimento { get; set; }

        public ClienteInfo ProdutoInfo { get; set; }
    }
}
