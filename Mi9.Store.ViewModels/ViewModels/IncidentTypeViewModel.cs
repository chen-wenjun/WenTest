using Newtonsoft.Json;

namespace Mi9.Store.ViewModels.ViewModels
{
    [JsonObject(MemberSerialization.OptIn)]
    public class IncidentTypeViewModel
    {
        [JsonProperty(PropertyName = "id")]
        public int Id { get; set; }

        [JsonProperty(PropertyName = "type")]
        public string Name { get; set; }

        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }

        [JsonProperty(PropertyName = "active")]
        public bool Active { get; set; }
    }
}