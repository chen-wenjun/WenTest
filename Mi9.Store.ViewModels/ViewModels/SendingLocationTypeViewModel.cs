using Newtonsoft.Json;

namespace Mi9.Store.ViewModels.ViewModels
{
    public class SendingLocationTypeViewModel
    {
        [JsonProperty(PropertyName = "id")]
        public int Id { get; set; }

        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }
    }
}
