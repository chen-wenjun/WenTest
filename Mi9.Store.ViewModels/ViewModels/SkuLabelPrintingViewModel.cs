using Mi9.Store.Entities.Entities;
using Newtonsoft.Json;

namespace Mi9.Store.ViewModels.ViewModels
{
    public class SkuLabelPrintingViewModel
    {
        [JsonProperty(PropertyName = "labelType")]
        public string labelType { get; set; }

        [JsonProperty(PropertyName = "labelTypeDescription")]
        public string LabelTypeDescription { get; set; }

        [JsonProperty(PropertyName = "number")]
        public long Sku;

        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }

        [JsonProperty(PropertyName = "upc")]
        public string Upc;

        [JsonProperty(PropertyName = "retailPrice")]
        public decimal? RetailPrice;

        [JsonProperty(PropertyName = "promoPrice")]
        public decimal? PromoPrice;

        [JsonProperty(PropertyName = "quantityOnHand")]
        public decimal? QuantityOnHand;

        [JsonProperty(PropertyName = "numberOfLabel")]
        public byte NumberOfLabels;

        [JsonProperty(PropertyName = "deleted")]
        public bool Deleted { get; set; }

        [JsonProperty(PropertyName = "hasPrice")]
        public bool HasPrice { get; set; }

        [JsonProperty(PropertyName = "printer")]
        public PrinterEntity Printer { get; set; }

        [JsonProperty(PropertyName = "column")]
        public int Column { get; set; }

        [JsonProperty(PropertyName = "row")]
        public int Row { get; set; }

        [JsonProperty(PropertyName = "index")]
        public int Index { get; set; }

        [JsonProperty(PropertyName = "pendingPrice")]
        public bool PendingPrice { get; set; }

        [JsonProperty(PropertyName = "validPromotion")]
        public bool ValidPromotion { get; set; }

        [JsonProperty(PropertyName = "promotionCode")]
        public string PromotionCode { get; set; }

    }
}
