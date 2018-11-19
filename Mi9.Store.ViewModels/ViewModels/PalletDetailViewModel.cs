using System.Collections.Generic;
using Newtonsoft.Json;

namespace Mi9.Store.ViewModels.ViewModels
{
    public class PalletDetailViewModel
    {
        [JsonProperty(PropertyName = "sku")]
        public long SKU { get; set; }

        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }

        [JsonProperty(PropertyName = "velocityCode")]
        public string VelocityCode { get; set; }

        [JsonProperty(PropertyName = "remarks")]
        public string Remarks { get; set; }

        [JsonProperty(PropertyName = "home")]
        public IEnumerable<string> Home { get; set; }

        [JsonProperty(PropertyName = "over")]
        public IEnumerable<string> Over { get; set; }
    }
}

