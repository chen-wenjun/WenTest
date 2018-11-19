using Newtonsoft.Json;

namespace Mi9.Store.ViewModels.ViewModels
{
    public class ReceivingGridPrintViewModel
    {
        [JsonProperty(PropertyName = "SKU")]
        public string SKU { get; set; }

        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }

        [JsonProperty(PropertyName = "CV")]
        public string CV { get; set; }

        [JsonProperty(PropertyName = "Observ")]
        public string Observ;

        [JsonProperty(PropertyName = "Home")]
        public string Home { get; set; }

        [JsonProperty(PropertyName = "Over")]
        public string Over { get; set; }
    }
}
