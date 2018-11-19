using Newtonsoft.Json;

namespace Mi9.Store.ViewModels.ViewModels
{
    public class TenderTypeViewModel
    {
        [JsonProperty(PropertyName = "id")]
        public byte TenderCode { get; set; }

        [JsonProperty(PropertyName = "name")]
        public string Description { get; set; }

        [JsonProperty(PropertyName = "rate")]
        public decimal Rate { get; set; }

        [JsonProperty(PropertyName = "isTransportable")]
        public bool IsTransportable { get; set; }

        [JsonProperty(PropertyName = "isCash")]
        public bool IsCash { get; set; }

        [JsonProperty(PropertyName = "isFormOfPayment")]
        public bool IsFormOfPayment { get; set; }

        [JsonProperty(PropertyName = "formOfPaymentName")]
        public string FormOfPaymentName { get; set; }
    }
}