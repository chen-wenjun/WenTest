using Newtonsoft.Json;

namespace Mi9.Store.ViewModels.ViewModels
{
    public class InventoryInquirySkuRequestViewModel
    {
        [JsonProperty(PropertyName = "sku")]
        public long SKU { get; set; }

        [JsonProperty(PropertyName = "uom")]
        public string UomCode { get; set; }

        [JsonProperty(PropertyName = "quantity")]
        public decimal Quantity { get; set; }
    }
}
