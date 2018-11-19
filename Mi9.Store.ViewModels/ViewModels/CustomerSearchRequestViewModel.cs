using Newtonsoft.Json;

namespace Mi9.Store.ViewModels.ViewModels
{
    public class CustomerSearchRequestViewModel
    {
        [JsonProperty("customerId")]
        public long? CustomerId { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("rfc")]
        public string Rfc { get; set; }

        [JsonProperty("curp")]
        public string Curp { get; set; }

        [JsonProperty("city")]
        public string City { get; set; }

        [JsonProperty("state")]
        public string State { get; set; }

        [JsonProperty("customerType")]
        public string CustomerType { get; set; }
    }
}