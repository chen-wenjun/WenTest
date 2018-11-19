using Newtonsoft.Json;

namespace Mi9.Store.ViewModels.ViewModels
{
    public class PurchaseOrderStatusViewModel
    {
        [JsonProperty(PropertyName = "value")]
        public string Value { get; set; }

        [JsonProperty(PropertyName = "title")]
        public string Title { get; set; }
    }
}