using Newtonsoft.Json;

namespace Mi9.Store.ViewModels.ViewModels
{
    public class ShipMethodViewModel
    {
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }

        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }

        [JsonProperty(PropertyName = "hOApprovalRequired")]
        public bool HOApprovalRequired { get; set; }
    }
}
