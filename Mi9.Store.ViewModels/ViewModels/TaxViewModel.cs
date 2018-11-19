using Newtonsoft.Json;

namespace Mi9.Store.ViewModels.ViewModels
{
    [JsonObject(MemberSerialization.OptIn)]
    public class TaxViewModel
    {
        [JsonProperty(PropertyName = "taxCode")]
        public string TaxCode { get; set; }

        [JsonProperty(PropertyName = "taxName")]
        public string TaxName { get; set; }

        [JsonProperty(PropertyName = "taxRate")]
        public decimal? TaxRate { get; set; }

        [JsonProperty(PropertyName = "isTaxIncluded")]
        public bool IsTaxIncluded { get; set; }
    }
}
