using Newtonsoft.Json;

namespace Mi9.Store.ViewModels.ViewModels
{
    public class ReasonCodeViewModel
    {
        [JsonProperty(PropertyName = "reasonCode")]
        public byte ReasonCode { get; set; }

        [JsonProperty(PropertyName = "adjustType")]
        public string AdjustType { get; set; }

        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }
    }
}
