using System;
using Mi9.Store.ViewModels.Converters;
using Newtonsoft.Json;

namespace Mi9.Store.ViewModels.ViewModels
{
    
    public class ExchangeRateViewModel
    {
        [JsonProperty(PropertyName = "id")]
        public byte Code { get; set; }

        [JsonProperty(PropertyName = "name")]
        public string Description { get; set; }

        [JsonProperty(PropertyName = "rate")]
        public decimal Rate { get; set; }

        [JsonProperty(PropertyName = "dateTimeActivated")]
        [JsonConverter(typeof(IsoUtcDateTimeConverter))]
        public DateTime DateTimeActivated { get; set; }
    }
}