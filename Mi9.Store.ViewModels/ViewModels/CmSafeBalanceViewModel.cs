using Newtonsoft.Json;

namespace Mi9.Store.ViewModels.ViewModels
{
    public class CmSafeBalanceViewModel
    {
        [JsonProperty(PropertyName = "id")]
        public int Id { get; set; }

        [JsonProperty(PropertyName = "currencyId")]
        public int CurrencyId { get; set; }

        [JsonProperty(PropertyName = "tenderAmount")]
        public decimal TenderAmount { get; set; }

        [JsonProperty(PropertyName = "count")]
        public int? TenderCount { get; set; }
    }
}
