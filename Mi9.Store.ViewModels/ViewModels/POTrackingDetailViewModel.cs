using System;
using Mi9.Store.ViewModels.Converters;
using Newtonsoft.Json;

namespace Mi9.Store.ViewModels.ViewModels
{
    public class PoTrackingDetailViewModel
    {
        [JsonProperty("id")]
        public long Id { get; set; }
        [JsonProperty("poNumber")]
        public string PoNumber { get; set; }
        [JsonProperty("contactName")]
        public string ContactName { get; set; }
        [JsonProperty("estimatedDate")]
        [JsonConverter(typeof(IsoUtcDateTimeConverter))]
        public DateTime? EstimatedDate { get; set; }
        [JsonProperty("date")]
        [JsonConverter(typeof(IsoUtcDateTimeConverter))]
        public DateTime? Date { get; set; }
        [JsonProperty("user")]
        public PoTrackingUserViewModel User { get; set; }
        [JsonProperty("notes")]
        public string Notes { get; set; }
        [JsonProperty("stateInfo")]
        public PoTrackingStateViewModel StateInfo { get; set; }
    }
}
