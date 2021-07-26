using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ValidacaoNETCoreComplexFluentValidation.Application.Exceptions
{
    public class ValidationException : ApplicationException
    {
        public List<string> ValidationErrors { get; set; }

        public ValidationException(ValidationResult validationResult)
        {
            ValidationErrors = new List<string>();

            foreach (var validationErrors in validationResult.Errors)
            {
                ValidationErrors.Add(validationErrors.ErrorMessage);
            }
        }
    }
}
