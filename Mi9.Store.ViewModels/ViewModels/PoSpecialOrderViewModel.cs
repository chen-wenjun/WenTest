
using Mi9.Store.ViewModels.Converters;

namespace Mi9.Store.ViewModels.ViewModels
{
    using System;
    using Newtonsoft.Json;

    public class PoSpecialOrderViewModel
    {
        [JsonProperty(PropertyName = "id")]
        public string PurchaseOrderNumber { get; set; }

        [JsonProperty(PropertyName = "type")]
        public string Type { get; set; }

        [JsonProperty(PropertyName = "notes")]
        public string Notes { get; set; }

        [JsonProperty(PropertyName = "specialStatus")]
        public PurchaseOrderStateHistoryStatusViewModel SpecialOrderStatus { get; set; }

        [JsonProperty(PropertyName = "cancelStatus")]
        public PurchaseOrderStateHistoryStatusViewModel CancelStatus { get; set; }

        [JsonProperty(PropertyName = "createDate")]
        [JsonConverter(typeof(IsoUtcDateTimeConverter))]
        public DateTime CreateDate { get; set; }

        [JsonProperty(PropertyName = "contact")]
        public string ContactName { get; set; }

        [JsonProperty(PropertyName = "nextStatus")]
        public PurchaseOrderStateHistoryStatusViewModel NextStatus { get; set; }

        [JsonProperty(PropertyName = "shipToArvDate")]
        [JsonConverter(typeof(IsoUtcDateTimeConverter))]
        public DateTime ShipDate { get; set; }

        [JsonProperty(PropertyName = "actualDate")]
        [JsonConverter(typeof(IsoUtcDateTimeConverter))]
        public DateTime ActualDate { get; set; }

        [JsonProperty(PropertyName = "user")]
        public string User { get; set; }

        [JsonProperty(PropertyName = "customerOrder")]
        public string CustomerOrderNumber { get; set; }

        [JsonProperty(PropertyName = "vendor")]
        public virtual VendorViewModel Vendor { get; set; }

        [JsonProperty(PropertyName = "customer")]
        public CustomerViewModel Customer { get; set; }

        [JsonProperty(PropertyName = "status")]
        public string Status { get; set; }

        [JsonProperty(PropertyName = "deliveryTo")]
        public string DeliveryTo { get; set; }

        [JsonProperty(PropertyName = "isMdc")]
        public bool IsMdc { get; set; }
    }
}
