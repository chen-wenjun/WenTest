using Newtonsoft.Json;

namespace Mi9.Store.ViewModels.ViewModels
{
    public class PrecalculatedFinalTenderTotalsViewModel
    {
        [JsonProperty(PropertyName = "tenderTypeId")]
        public byte TenderTypeId { get; set; }

        [JsonProperty(PropertyName = "tenderTypeName")]
        public string TenderTypeName { get; set; }

        [JsonProperty(PropertyName = "tenderId")]
        public int? TenderId { get; set; }

        [JsonProperty(PropertyName = "tenderName")]
        public string TenderName { get; set; }

        [JsonProperty(PropertyName = "tenderKey")]
        public string TenderKey { get; set; }

        [JsonProperty(PropertyName = "total")]
        public decimal Total { get; set; }

        [JsonProperty(PropertyName = "isCash")]
        public bool IsCash { get; set; }
    }
}