using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Mi9.Store.Localization;
using Mi9.Store.ViewModels.Converters;
using Mi9.Store.ViewModels.ViewModels.Enums;
using Newtonsoft.Json;

namespace Mi9.Store.ViewModels.ViewModels
{
    public class CmPickUpViewModel : IValidatableObject
    {
        [JsonProperty(PropertyName = "id")]
        public int Id { get; set; }

        [JsonProperty(PropertyName = "balancingMethod")]
        public string BalancingMethod { get; set; }

        [JsonProperty(PropertyName = "ownerId")]
        public int OwnerId { get; set; }

        [JsonProperty(PropertyName = "ownerName")]
        public string OwnerName { get; set; }

        [JsonProperty(PropertyName = "drawer")]
        public DrawerViewModel Drawer { get; set; }

        [JsonConverter(typeof(IsoUtcDateTimeConverter))]
        [JsonProperty(PropertyName = "dateTime")]
        public DateTime DateTime { get; set; }

        [JsonProperty(PropertyName = "tenders")]
        public ICollection<CmPickUpTenderViewModel> Tenders { get; set; }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            if (BalancingMethod != BalancingMethods.Cashier.ToString().ToLowerInvariant() && BalancingMethod != BalancingMethods.Register.ToString().ToLowerInvariant())
                throw new Exception(Strings.CashManagement_InvalidBalancingMethod);

            if (OwnerId <= 0)
            {
                if (BalancingMethod == BalancingMethods.Cashier.ToString().ToLowerInvariant())
                    yield return new ValidationResult(Strings.CashManagement_InvalidCashierId);

                if (BalancingMethod == BalancingMethods.Register.ToString().ToLowerInvariant())
                    yield return new ValidationResult(Strings.CashManagement_InvalidRegisterId);
            }

            if (Drawer.Drawer < 1 || Drawer.Drawer > 3)
                yield return new ValidationResult(Strings.CashManagement_InvalidDrawerNumber);
        }
    }
}
