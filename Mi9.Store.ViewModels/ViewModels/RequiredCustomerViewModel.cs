using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Mi9.Store.ViewModels.ViewModels.Enums;

namespace Mi9.Store.ViewModels.ViewModels
{
    public class RequiredCustomerViewModel : CustomerViewModel, IValidatableObject
    {
        public RequiredCustomerViewModel()
        {
            CustomerType = CustomerTypes.Regular;
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            if (CustomerId < 0)
            {
                yield return new ValidationResult("CustomerId is required field");
            }
        }
    }
}