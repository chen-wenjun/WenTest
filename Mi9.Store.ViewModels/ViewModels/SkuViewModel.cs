using Newtonsoft.Json;

namespace Mi9.Store.ViewModels.ViewModels
{
    public class SkuViewModel
    {
        [JsonProperty(PropertyName = "hasPrice")]
        public bool HasPrice { get; set; }

        [JsonProperty(PropertyName = "number")]
        public long Number { get; set; }

        [JsonProperty(PropertyName = "numberOfLabel")]
        public byte NumberOfLabel { get; set; }

        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }

        [JsonProperty(PropertyName = "validPromotion")]
        public bool ValidPromotion { get; set; }

        [JsonProperty(PropertyName = "promotionCode")]
        public string PromotionCode { get; set; }
    }
}
