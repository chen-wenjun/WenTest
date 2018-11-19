using Newtonsoft.Json;

namespace Mi9.Store.ViewModels.ViewModels
{
    public class PoTrackingEntryCustomerInfoViewModel
    {
        [JsonProperty("id")]
        public long? Id { get; set; }
        [JsonProperty("fullName")]
        public string FullName { get; set; }
        [JsonProperty("phone1")]
        public string Phone1 { get; set; }
        [JsonProperty("phone2")]
        public string Phone2 { get; set; }
    }
}