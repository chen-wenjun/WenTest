using Newtonsoft.Json;

namespace Mi9.Store.ViewModels.ViewModels
{
    public class ResaleSpecialOrderItemViewModel
    {
        /// <summary>
        /// Gets or sets the customer order id.
        /// </summary>
        [JsonProperty(PropertyName = "customerOrder")]
        public int CustomerOrderId { get; set; }

        /// <summary>
        /// Gets or sets the customer id.
        /// </summary>
        [JsonProperty(PropertyName = "customer")]
        public long CustomerId { get; set; }

        /// <summary>
        /// Gets or sets the customer id.
        /// </summary>
        [JsonProperty(PropertyName = "skuDescription")]
        public string SkuDescription { get; set; }

        /// <summary>
        /// Gets or sets the customer name.
        /// </summary>
        [JsonProperty(PropertyName = "customerName")]
        public string CustomerName { get; set; }

        /// <summary>
        /// Gets or sets the sku id.
        /// </summary>
        [JsonProperty(PropertyName = "sku")]
        public long? SkuId { get; set; }

        /// <summary>
        /// Gets or sets the quantity.
        /// </summary>
        [JsonProperty(PropertyName = "quantity")]
        public decimal Quantity { get; set; }
    }
}
