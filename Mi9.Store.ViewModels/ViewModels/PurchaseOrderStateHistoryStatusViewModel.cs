using Newtonsoft.Json;

namespace Mi9.Store.ViewModels.ViewModels
{    
    public class PurchaseOrderStateHistoryStatusViewModel
    {
        [JsonProperty(PropertyName = "code")]
        public string Code { get; set; }

        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        [JsonProperty(PropertyName = "order")]
        public int Order { get; set; }
    }
}
