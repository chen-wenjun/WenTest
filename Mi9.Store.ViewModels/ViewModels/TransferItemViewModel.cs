using Newtonsoft.Json;
using System;

namespace Mi9.Store.ViewModels.ViewModels
{
    public class TransferItemViewModel
    {
        [JsonProperty(PropertyName = "number")]
        public string TransferNumber { get; set; }

        [JsonProperty(PropertyName = "MDC")]
        public string MDC { get; set; }

        [JsonProperty(PropertyName = "deliveryDate")]
        public DateTime DeliveryDate { get; set; }

        [JsonProperty(PropertyName = "quantity")]
        public decimal ShipQuantity { get; set; }

        [JsonProperty(PropertyName = "SKU")]
        public long SKU { get; set; }
    }
}
