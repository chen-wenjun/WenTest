using Newtonsoft.Json;

namespace Mi9.Store.ViewModels.ViewModels
{
    public class InventoryCategoryViewModel
    {
        [JsonProperty(PropertyName = "id")]
        public int Id { get; set; }

        [JsonProperty(PropertyName = "code")]
        public string Code { get; set; }

        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }

        [JsonProperty(PropertyName = "disabled")]
        public bool? Disabled { get; set; }
    }
}