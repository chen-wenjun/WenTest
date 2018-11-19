using Newtonsoft.Json;

namespace Mi9.Store.ViewModels.ViewModels
{
    public class CancelledReceivedOrderItemViewModel
    {
        [JsonProperty(PropertyName = "customerOrder")]
        public int CustomerOrderId { get; set; }

        [JsonProperty(PropertyName = "customer")]
        public long CustomerId { get; set; }

        [JsonProperty(PropertyName = "skuDescription")]
        public string SkuDescription { get; set; }

        [JsonProperty(PropertyName = "customerName")]
        public string CustomerName { get; set; }

        [JsonProperty(PropertyName = "sku")]
        public long? SkuId { get; set; }

        [JsonProperty(PropertyName = "purchaseOrder")]
        public string SpecialPurchaseOrder { get; set; }

        [JsonProperty(PropertyName = "quantity")]
        public decimal Quantity { get; set; }
    }
}
