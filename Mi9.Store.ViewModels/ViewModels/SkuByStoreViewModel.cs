using Newtonsoft.Json;

namespace Mi9.Store.ViewModels.ViewModels
{
    public class SkuByStoreViewModel
    {
        [JsonProperty(PropertyName = "sourceStore")]
        public StoreViewModel SourceStore { get; set; }

        [JsonProperty(PropertyName = "sku")]
        public long Sku { get; set; }

        [JsonProperty(PropertyName = "status")]
        public string Status { get; set; }

        [JsonProperty(PropertyName = "vc")]
        public string Vc { get; set; }

        [JsonProperty(PropertyName = "unitCost")]
        public decimal UnitCost { get; set; }

        [JsonProperty(PropertyName = "unitRetail")]
        public decimal UnitRetail { get; set; }

        [JsonProperty(PropertyName = "onOrder")]
        public decimal OnOrder { get; set; }

        [JsonProperty(PropertyName = "available")]
        public decimal Available { get; set; }

        [JsonProperty(PropertyName = "weekOfInventory")]
        public decimal WeekOfInventory { get; set; }

        [JsonProperty(PropertyName = "requestQty")]
        public decimal RequestQty { get; set; }
    }
}
