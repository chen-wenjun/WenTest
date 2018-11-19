using Newtonsoft.Json;

namespace Mi9.Store.ViewModels.ViewModels
{    
    public class PurchaseOrderControlViewModel
    {
        [JsonProperty(PropertyName = "id")]
        public bool Id { get; set; }

        [JsonProperty(PropertyName = "dropDeadDays")]
        public byte DropDeadDays { get; set; }
    }
}