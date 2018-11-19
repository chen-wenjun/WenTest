using Mi9.Store.ViewModels.Converters;
using System;
using Newtonsoft.Json;

namespace Mi9.Store.ViewModels.ViewModels
{
    public class TransferMinimizedViewModel
    {
        [JsonProperty(PropertyName = "number")]
        public string TransferNumber { get; set; }
        
        [JsonProperty(PropertyName = "status")]
        public string Status { get; set; }
        
        [JsonProperty(PropertyName = "createDate")]
        [JsonConverter(typeof(IsoUtcDateTimeConverter))]
        public DateTime? DateCreated { get; set; }

        [JsonProperty(PropertyName = "hOInitiated")]
        public bool HOInitiated { get; set; }
    }
}
