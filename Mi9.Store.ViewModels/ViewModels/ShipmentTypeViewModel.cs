using Newtonsoft.Json;

namespace Mi9.Store.ViewModels.ViewModels
{
    public class ShipmentTypeViewModel
    {
        [JsonProperty("id")]
        public string Id { get; set; }
        [JsonProperty("description")]
        public string Description { get; set; }
    }
}