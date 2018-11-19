using Newtonsoft.Json;

namespace Mi9.Store.ViewModels.ViewModels
{
    public class PoTrackingEntryVendorInfoViewModel
    {
        [JsonProperty("id")]
        public string Id { get; set; }
        [JsonProperty("suffix")]
        public int Suffix { get; set; }
        [JsonProperty("name")]
        public string Name { get; set; }
        [JsonProperty("contactName")]
        public string ContactName { get; set; }
        [JsonProperty("contactPhone")]
        public string ContactPhone { get; set; }
        [JsonProperty("contactEmail")]
        public string ContactEmail { get; set; }
    }
}