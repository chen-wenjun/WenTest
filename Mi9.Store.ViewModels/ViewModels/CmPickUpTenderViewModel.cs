using Newtonsoft.Json;

namespace Mi9.Store.ViewModels.ViewModels
{
    public class CmPickUpTenderViewModel
    {
        [JsonProperty(PropertyName = "id")]
        public byte Id { get; set; }

        [JsonProperty(PropertyName = "currencyId")]
        public byte CurrencyId { get; set; }
        
        [JsonProperty(PropertyName = "count")]
        public short Count { get; set; }

        [JsonProperty(PropertyName = "tenderAmount")]
        public decimal Amount { get; set; }

    }
}
