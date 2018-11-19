using Newtonsoft.Json;

namespace Mi9.Store.ViewModels.ViewModels
{
    public class ItemPrintingSettingViewModel
    {
        [JsonProperty(PropertyName = "sku")]
        public long Sku;

        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }

        [JsonProperty(PropertyName = "status")]
        public string Status { get; set; }

        [JsonProperty(PropertyName = "type")]
        public string Type { get; set; }

        [JsonProperty(PropertyName = "LabelType")]
        public string LabelType { get; set; }

        [JsonProperty(PropertyName = "numberOfLabel")]
        public byte NumberOfLabel { get; set; }

        [JsonProperty(PropertyName = "OnHand")]
        public decimal OnHand { get; set; }

        [JsonProperty(PropertyName = "Price")]
        public decimal Price { get; set; }

        [JsonProperty(PropertyName = "Promo")]
        public decimal Promo { get; set; }

        [JsonProperty(PropertyName = "homelocation")]
        public string HomeLocation { get; set; }

        [JsonProperty(PropertyName = "promotioncode")]
        public string PromotionCode { get; set; }

    }
}
