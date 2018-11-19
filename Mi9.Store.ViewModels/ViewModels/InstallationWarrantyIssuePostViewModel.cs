using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using Newtonsoft.Json;

namespace Mi9.Store.ViewModels.ViewModels
{
    
    public class InstallationWarrantyIssuePostViewModel : IValidatableObject
    {
        [JsonProperty("type")]
        public int WarrantyTypeId { get; set; }

        [JsonProperty("kind")]
        public int WarrantyChargeKindId { get; set; }

        [JsonProperty("originalRequestId")]
        public int OriginalRequestId { get; set; }

        [JsonProperty("services")]
        public Service[] Services { get; set; }

        public class Service
        {
            [JsonProperty("id")]
            public int ServiceId { get; set; }

            [JsonProperty("packId")]
            public int InstallationPackId { get; set; }

            [JsonProperty("packSequence")]
            public short ServiceSequence { get; set; }

            [JsonProperty("cost")]
            public decimal InstCost { get; set; }

            [JsonProperty("price")]
            public decimal InstPrice { get; set; }

            [JsonProperty("quantity")]
            public int Quantity { get; set; }

            [JsonProperty("charge")]
            public decimal Charge { get; set; }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            if (Services.Any(s => s.Charge < 0))
            {
                yield return new ValidationResult("The negative value of 'Charge cost' field is not allowed.");
            }
        }
    }
}