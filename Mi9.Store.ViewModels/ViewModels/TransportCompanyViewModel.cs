using Mi9.Store.ViewModels.Converters;

namespace Mi9.Store.ViewModels.ViewModels
{
    using System;
    using Newtonsoft.Json;

    public class TransportCompanyViewModel
    {
        [JsonProperty(PropertyName = "id")]
        public int Id { get; set; }

        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        [JsonProperty(PropertyName = "key")]
        public string Key { get; set; }

        [JsonProperty(PropertyName = "isActive")]
        public bool IsActive { get; set; }

        [JsonProperty(PropertyName = "created")]
        [JsonConverter(typeof(IsoUtcDateTimeConverter))]
        public DateTime Created { get; set; }
    }
}