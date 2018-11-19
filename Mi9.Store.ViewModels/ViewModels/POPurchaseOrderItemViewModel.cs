using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;

namespace Mi9.Store.ViewModels.ViewModels
{
    [JsonObject(MemberSerialization.OptIn)]
    public class PoPurchaseOrderItemViewModel : IValidatableObject
    {
        [JsonProperty(PropertyName = "sequenceId")]
        public int PurchaseOrderSeqNumber { get; set; }

        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }

        [JsonProperty(PropertyName = "vendorPack")]
        public short VendorPack { get; set; }

        [JsonProperty(PropertyName = "vendorPackUOM")]
        public string VendorUOM { get; set; }
        
        [JsonProperty(PropertyName = "soq")]
        public int SuggestQty { get; set; }

        [JsonProperty(PropertyName = "cost")]
        public decimal UnitCost { get; set; }
        
        [JsonProperty(PropertyName = "item")]
        public ItemSkuViewModel ItemSku { get; set; }

        [JsonProperty(PropertyName = "cube")]
        public decimal? UnitCube { get; set; }

        [JsonProperty(PropertyName = "total")]
        public PurchaseOrderItemInfoViewModel PurchaseOrderItemInfo { get; set; }

        [JsonProperty(PropertyName = "spanishDescription")]
        public string SpanishDesc { get; set; }

        [JsonProperty(PropertyName = "engDescription")]
        public string EngDesc { get; set; }

        [JsonProperty(PropertyName = "quantity")]
        public decimal OrderQty { get; set; }
        
        [JsonProperty(PropertyName = "unitFreight")]
        public decimal? UnitFreight { get; set; }

        public decimal CollectCost { get; set; }
        public decimal? PrepaidCost { get; set; }
        
        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            if (ItemSku == null)
            {
                yield return new ValidationResult("Item is required field");
            }
        }
    }
}