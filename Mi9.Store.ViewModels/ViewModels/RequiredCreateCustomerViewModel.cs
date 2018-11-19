using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Mi9.Store.ViewModels.ViewModels
{
    public class RequiredCreateCustomerViewModel : CustomerViewModel, IValidatableObject
    {
        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            if (this.CustomerId < 0)
            {
                yield return new ValidationResult("CustomerId is required field");
            }

            if (string.IsNullOrWhiteSpace(this.FirstName))
            {
                yield return new ValidationResult("FirstName is required field");
            }

            if (string.IsNullOrWhiteSpace(this.LastName))
            {
                yield return new ValidationResult("LastName is required field");
            }

            if (string.IsNullOrWhiteSpace(this.BusinessName))
            {
                yield return new ValidationResult("BusinessName is required field");
            }
        }
    }
}
