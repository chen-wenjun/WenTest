using Newtonsoft.Json;

namespace Mi9.Store.ViewModels.ViewModels
{
    [JsonObject(MemberSerialization.OptIn)]
    public class CountryDefinitionViewModel
    {
        [JsonProperty(PropertyName = "id")]
        public short Id { get; set; }

        [JsonProperty(PropertyName = "firstAddressLine")]
        public string FirstAddressLine { get; set; }

        [JsonProperty(PropertyName = "secondAddresLine")]
        public string SecondAddressLine { get; set; }

        [JsonProperty(PropertyName = "city")]
        public string City { get; set; }

        [JsonProperty(PropertyName = "state")]
        public string State { get; set; }

        [JsonProperty(PropertyName = "postalCode")]
        public string PostalCode { get; set; }

        [JsonProperty(PropertyName = "countryName")]
        public string CountryName { get; set; }
    }
}
