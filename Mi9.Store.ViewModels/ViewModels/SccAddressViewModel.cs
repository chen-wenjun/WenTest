using Newtonsoft.Json;

namespace Mi9.Store.ViewModels.ViewModels
{
   
    [JsonObject(MemberSerialization.OptIn)]
    public class SccAddressViewModel
    {        
        [JsonProperty(PropertyName = "id")]
        public int Id { get; set; }

        [JsonProperty(PropertyName = "country")]
        public string Country { get; set; }

        [JsonProperty(PropertyName = "postalCode")]
        public string PostalCode { get; set; }

        [JsonProperty(PropertyName = "street")]
        public string Street { get; set; }

        [JsonProperty(PropertyName = "city")]
        public string City { get; set; }

        [JsonProperty(PropertyName = "telephone1")]
        public string Telephone1 { get; set; }

        [JsonProperty(PropertyName = "telephone2")]
        public string Telephone2 { get; set; }

        [JsonProperty(PropertyName = "fax")]
        public string Fax { get; set; }

        [JsonProperty(PropertyName = "state")]
        public StateViewModel State { get; set; }
    }
}
