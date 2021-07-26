using System;

namespace ValidacaoNETCoreComplexFluentValidation.Persistence
{
    public class ClienteService : IClienteService
    {
        public ClienteService SaveClientePega()
        {
            var validationService = new ClientePegaValidator();
            var validationResult = validationService.Validate(clientePega);


        }
    }
}



//https://jber595.medium.com/net-core-complex-properties-validation-using-fluentvalidation-e204c5e8e7c1