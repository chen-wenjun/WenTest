using Newtonsoft.Json;

namespace Mi9.Store.ViewModels.ViewModels
{
    public class CmDepositDetailViewModel
    {
        [JsonProperty(PropertyName = "id")]
        public int TenderId { get; set; }

        [JsonProperty(PropertyName = "currencyId")]
        public int CurrencyId { get; set; }

        [JsonProperty(PropertyName = "count")]
        public int TenderCount { get; set; }

        [JsonProperty(PropertyName = "amount")]
        public decimal TenderAmount { get; set; }
    }
}
