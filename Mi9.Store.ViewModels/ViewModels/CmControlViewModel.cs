using Newtonsoft.Json;

namespace Mi9.Store.ViewModels.ViewModels
{
    public class CmControlViewModel
    {
        [JsonIgnore]
        public int Id { get; set; }

        [JsonProperty(PropertyName = "startBankAmount")]
        public decimal StartBankAmount { get; set; }

        [JsonProperty(PropertyName = "cashThreshold")]
        public decimal MaxCashDrawer { get; set; }

        [JsonProperty(PropertyName = "balancingMethod")]
        public string BalancingMethod { get; set; }

        [JsonProperty(PropertyName = "automaticDepositNumber")]
        public bool AutoDepNumber { get; set; }

        [JsonProperty(PropertyName = "blindBalance")]
        public bool BlindBalance { get; set; }

        [JsonProperty(PropertyName = "baseCurrency")]
        public string BaseCurrency { get; set; }
    }
}
