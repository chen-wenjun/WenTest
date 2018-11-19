using System.Collections.Generic;
using Newtonsoft.Json;

namespace Mi9.Store.ViewModels.ViewModels
{
    public class CmTenderViewModel
    {
        [JsonProperty(PropertyName = "id")]
        public int Id { get; set; }
        [JsonProperty(PropertyName = "currency")]
        public CmCurrencyViewModel Currency { get; set; }
        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }
        [JsonProperty(PropertyName = "isCurrency")]
        public bool IsCurrency { get; set; }
        [JsonProperty(PropertyName = "safeTender")]
        public bool SafeTender { get; set; }
        [JsonProperty(PropertyName = "denominations")]
        public ICollection<CmDenominationViewModel> Denominations { get; set; }
    }
}
