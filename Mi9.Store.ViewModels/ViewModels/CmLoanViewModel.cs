using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Mi9.Store.Localization;
using Mi9.Store.ViewModels.Converters;
using Mi9.Store.ViewModels.ViewModels.Enums;
using Newtonsoft.Json;

namespace Mi9.Store.ViewModels.ViewModels
{
    public class CmLoanViewModel : IValidatableObject
    {
        [JsonProperty(PropertyName = "balancingMethod")]
        public string BalancingMethod { get; set; }

        [JsonProperty(PropertyName = "ownerId")]
        public int OwnerId { get; set; }
        
        [JsonProperty(PropertyName = "drawer")]
        public byte Drawer { get; set; }
        
        [JsonProperty(PropertyName = "amount")]
        public decimal Amount { get; set; }

        [JsonConverter(typeof(IsoUtcDateTimeConverter))]
        [JsonProperty(PropertyName = "date")]
        public DateTime Date { get; set; }

        [JsonProperty(PropertyName = "loanType")]
        public string LoanType { get; set; }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            if (LoanType != CashOfficeLoanTypes.Bank.ToString().ToLowerInvariant() && LoanType != CashOfficeLoanTypes.Loan.ToString().ToLowerInvariant())
                yield return new ValidationResult(Strings.CashManagement_InvalidBalancingMethod);

            if (BalancingMethod != BalancingMethods.Cashier.ToString().ToLowerInvariant() && BalancingMethod != BalancingMethods.Register.ToString().ToLowerInvariant())
                yield return new ValidationResult(Strings.CashManagement_InvalidBalancingMethod);

            if (OwnerId <= 0)
            {
                if (BalancingMethod == BalancingMethods.Cashier.ToString().ToLowerInvariant())
                    yield return new ValidationResult(Strings.CashManagement_InvalidCashierId);

                if (BalancingMethod == BalancingMethods.Register.ToString().ToLowerInvariant())
                    yield return new ValidationResult(Strings.CashManagement_InvalidRegisterId);
            }

            if (Drawer < 1 || Drawer > 3)
                yield return new ValidationResult(Strings.CashManagement_InvalidDrawerNumber);

            if (Amount <= 0)
                yield return new ValidationResult(Strings.CashManagement_InvalidAmount); 
            
        }
    }
}

