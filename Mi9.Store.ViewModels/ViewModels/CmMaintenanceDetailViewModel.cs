using Newtonsoft.Json;

namespace Mi9.Store.ViewModels.ViewModels
{
    public class CmMaintenanceDetailViewModel
    {
        [JsonProperty(PropertyName = "id")]
        public int TenderId { get; set; }

        [JsonProperty(PropertyName = "currencyId")]
        public int CurrencyId { get; set; }

        [JsonProperty(PropertyName = "amountInSafe")]
        public decimal AmountInSafe { get; set; }

        [JsonProperty(PropertyName = "tenderAmount")]
        public decimal TenderAmount { get; set; }

        [JsonProperty(PropertyName = "countInSafe")]
        public int CountInSafe { get; set; }

        [JsonProperty(PropertyName = "tenderCount")]
        public int TenderCount { get; set; }
    }
}
