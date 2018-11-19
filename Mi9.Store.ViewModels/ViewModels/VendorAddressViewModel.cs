using Newtonsoft.Json;

namespace Mi9.Store.ViewModels.ViewModels
{
    public class VendorAddressViewModel
    {
        [JsonProperty(PropertyName = "addr1")]
        public string Addr1 { get; set; }

        [JsonProperty(PropertyName = "addr2")]
        public string Addr2 { get; set; }

        [JsonProperty(PropertyName = "addr3")]
        public string Addr3 { get; set; }
        
        [JsonProperty(PropertyName = "city")]
        public string City { get; set; }
        
        [JsonProperty(PropertyName = "state")]
        public string State { get; set; }
        
        [JsonProperty(PropertyName = "zip")]
        public string Zip { get; set; }
    }
}