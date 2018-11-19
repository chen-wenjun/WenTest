using Newtonsoft.Json;

namespace Mi9.Store.ViewModels.ViewModels
{
    public class CashierViewModel
    {
        [JsonProperty(PropertyName = "id")]
        public int CashierId { get; set; }

        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }
    }
}