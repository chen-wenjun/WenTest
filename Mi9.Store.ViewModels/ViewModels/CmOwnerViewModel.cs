using Newtonsoft.Json;

namespace Mi9.Store.ViewModels.ViewModels
{
    public class CmOwnerViewModel
    {
        [JsonProperty(PropertyName = "id")]
        public int Id { get; set; }
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }
    }
    
}
