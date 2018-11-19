using Newtonsoft.Json;

namespace Mi9.Store.ViewModels.ViewModels
{
    public class CmCurrencyViewModel
    {
        [JsonProperty(PropertyName = "id")]
        public int Id { get; set; }

        [JsonProperty(PropertyName = "symbol")]
        public string Symbol { get; set; }

        [JsonProperty(PropertyName = "code")]
        public string Code { get; set; }

        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }

        [JsonProperty(PropertyName = "exchangeRate")]
        public decimal Rate { get; set; }

        [JsonProperty(PropertyName = "isBaseCurrency")]
        public bool IsBaseCurrency { get; set; }
    }
}
