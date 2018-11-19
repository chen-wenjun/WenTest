using Newtonsoft.Json;

namespace Mi9.Store.ViewModels.ViewModels
{
    [JsonObject(MemberSerialization.OptIn)]
    public class AddressViewModel
    {
        public int Id { get; set; }

        [JsonProperty(PropertyName = "postalCode")]
        public string PostalCode { get; set; }

        [JsonProperty(PropertyName = "addressLine1")]
        public string AddressLine { get; set; }

        [JsonProperty(PropertyName = "addressLine2")]
        public string Municipality { get; set; }

        [JsonProperty(PropertyName = "country")]
        public CountryViewModel Country { get; set; }

        [JsonProperty(PropertyName = "colony")]
        public string Colony { get; set; }

        [JsonProperty(PropertyName = "stateId")]
        public string StateId { get; set; }

        [JsonProperty(PropertyName = "state")]
        public StateViewModel State { get; set; }

        [JsonProperty(PropertyName = "city")]
        public string City { get; set; }

        [JsonProperty(PropertyName = "latitude")]
        public double? Latitude { get; set; }

        [JsonProperty(PropertyName = "longitude")]
        public double? Longitude { get; set; }

        [JsonProperty(PropertyName = "zone")]
        public ZoneViewModel Zone { get; set; }

        public int Number { get; set; }

        public string Neighborhood { get; set; }

        public decimal DeliveryDistance { get; set; }

        [JsonProperty(PropertyName = "maneuverDistance")]
        public double DeliveryManeuverDistance { get; set; }

        [JsonProperty(PropertyName = "maneuverElevation")]
        public double DeliveryManeuverElevation { get; set; }
    }
}