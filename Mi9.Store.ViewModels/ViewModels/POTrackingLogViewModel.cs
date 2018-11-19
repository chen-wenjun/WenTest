using System;
using Mi9.Store.ViewModels.Converters;
using Newtonsoft.Json;

namespace Mi9.Store.ViewModels.ViewModels
{
    public class PoTrackingLogViewModel
    {
        [JsonProperty("id")]
        public long Id { get; set; }
        [JsonProperty("poNumber")]
        public string PONumber { get; set; }
        [JsonProperty("notes")]
        public string Notes { get; set; }
        [JsonProperty("date")]
        [JsonConverter(typeof(IsoUtcDateTimeConverter))]
        public DateTime Date { get; set; }
        [JsonProperty("user")]
        public PoTrackingUserViewModel User { get; set; }
        [JsonProperty("logType")]
        public PoTrackingLogTypeViewModel LogType { get; set; }
        [JsonProperty("state")]
        public PoTrackingStateViewModel State { get; set; }
        [JsonProperty("contactName")]
        public string ContactName { get; set; }
    }
}
