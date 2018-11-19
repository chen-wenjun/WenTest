using Newtonsoft.Json;

namespace Mi9.Store.ViewModels.ViewModels
{    
    public class ReasonTypeViewModel
    {
        [JsonProperty(PropertyName = "id")]
        public int Id { get; set; }

        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        [JsonProperty(PropertyName = "code")]
        public string Code { get; set; }

        [JsonProperty(PropertyName = "color")]
        public string Color { get; set; }
    }
}
