using System;
using Mi9.Store.ViewModels.Converters;
using Newtonsoft.Json;

namespace Mi9.Store.ViewModels.ViewModels
{
    public class PurchaseOrderStateHistoryDetailViewModel
    {
        [JsonProperty(PropertyName = "poId")]
        public string PurchaseOrderNumber { get; set; }

        [JsonProperty(PropertyName = "Step")]
        public long Step { get; set; }

        [JsonProperty(PropertyName = "type")]
        public string Type { get; set; }

        [JsonProperty(PropertyName = "specialStatus")]
        public PurchaseOrderStateHistoryStatusViewModel SpecialStatus { get; set; }

        [JsonProperty(PropertyName = "cancelStatus")]
        public PurchaseOrderStateHistoryStatusViewModel CancelStatus { get; set; }

        [JsonProperty(PropertyName = "notes")]
        public string Notes { get; set; }

        [JsonProperty(PropertyName = "actualDate")]
        [JsonConverter(typeof(IsoUtcDateTimeConverter))]
        public DateTime ActualDate { get; set; }

        [JsonConverter(typeof(IsoUtcDateTimeConverter))]
        [JsonProperty(PropertyName = "estimate")]
        public DateTime Estimate { get; set; }

        [JsonProperty(PropertyName = "nextStatus")]
        public PurchaseOrderStateHistoryStatusViewModel NextStatus { get; set; }

        [JsonProperty(PropertyName = "user")]
        public string User { get; set; }

        [JsonProperty(PropertyName = "contact")]
        public string Contact { get; set; }
    }
}