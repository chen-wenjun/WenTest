
using Newtonsoft.Json;

namespace Mi9.Store.ViewModels.ViewModels
{
    public class PhyInvReviewViewModel
    {
        [JsonProperty(PropertyName = "modified")]
        public bool Modified { get; set; }

        [JsonProperty(PropertyName = "class")]
        public short? Class { get; set; }

        [JsonProperty(PropertyName = "sku")]
        public long Sku { get; set; }

        [JsonProperty(PropertyName = "systemQty")]
        public decimal SystemQty { get; set; }

        [JsonProperty(PropertyName = "countQty")]
        public decimal CountQty { get; set; }

        [JsonProperty(PropertyName = "systemCost")]
        public decimal SystemCost { get; set; }

        [JsonProperty(PropertyName = "unitCost")]
        public decimal UnitCost { get; set; }

        [JsonProperty(PropertyName = "retailPrice")]
        public decimal RetailPrice { get; set; }

        
    }
}
