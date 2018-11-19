using Newtonsoft.Json;

namespace Mi9.Store.ViewModels.ViewModels
{
    [JsonObject(MemberSerialization.OptIn)]
    public class SkuRequestItemViewModel
    {
        // TODO : Should we store old SKU price.

        [JsonProperty(PropertyName = "id")]
        public int Id { get; set; }

        [JsonProperty(PropertyName = "requestPrice")]
        public decimal RequestPrice { get; set; }

        [JsonProperty(PropertyName = "lastPrice")]
        public decimal LastPrice { get; set; }

        [JsonIgnore]
        public decimal AverageCost { get; set; }

        [JsonIgnore]
        public decimal RequestedMarginPercent { get; set; }

        [JsonIgnore]
        public decimal RequestedMargin { get; set; }

        [JsonProperty(PropertyName = "skuId")]
        public long SKUID { get; set; }

        [JsonProperty(PropertyName = "orderNumber")]
        public int OrderNumber { get; set; }

        [JsonProperty(PropertyName = "orderSeqNumber")] 
        public short OrdSeqNumber { get; set; }

        [JsonProperty(PropertyName = "authorizeLevel")]
        public string AuthorizationLevel { get; set; } // TODO : Implement levels as enum.

        [JsonProperty(PropertyName = "status")]
        public string Status { get; set; } // TODO : Implement status as enum.
    }
}