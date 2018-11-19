using System;
using Mi9.Store.ViewModels.Converters;
using Newtonsoft.Json;

namespace Mi9.Store.ViewModels.ViewModels
{    
    public class FinalTenderTotalsViewModel
    {
        [JsonProperty(PropertyName = "status")]
        public string Status { get; set; }

        [JsonProperty(PropertyName = "comment")]
        public string Comment { get; set; }

        [JsonProperty(PropertyName = "date")]
        [JsonConverter(typeof(IsoUtcDateTimeConverter))]
        public DateTime Date { get; set; }
    }
}