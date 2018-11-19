using Newtonsoft.Json;

namespace Mi9.Store.ViewModels.ViewModels
{
   
    [JsonObject(MemberSerialization.OptIn)]
    public class SccRequirementViewModel
    {
        [JsonProperty(PropertyName = "id")]
        public int Id { get; set; }

        [JsonProperty(PropertyName = "isRequiredAdvanceDeposit")]
        public bool IsRequiredAdvanceDeposit { get; set; }

        [JsonProperty(PropertyName = "amountAdvanceDeposit")]
        public int? AmountAdvanceDeposit { get; set; }

        [JsonProperty(PropertyName = "isStoreConfirmAdvanceDeposit")]
        public bool IsStoreConfirmAdvanceDeposit { get; set; }

        [JsonProperty(PropertyName = "isOatConfirmAdvanceDeposit")]
        public bool IsOatConfirmAdvanceDeposit { get; set; }

        [JsonProperty(PropertyName = "isRequiredCustomerPo")]
        public bool IsRequiredCustomerPo { get; set; }

        [JsonProperty(PropertyName = "isStoreConfirmCustomerPo")]
        public bool IsStoreConfirmCustomerPo { get; set; }

        [JsonProperty(PropertyName = "isOatConfirmCustomerPo")]
        public bool IsOatConfirmCustomerPo { get; set; }

        [JsonProperty(PropertyName = "isRequiredDeliverySchedule")]
        public bool IsRequiredDeliverySchedule { get; set; }

        [JsonProperty(PropertyName = "isStoreConfirmDeliverySchedule")]
        public bool IsStoreConfirmDeliverySchedule { get; set; }

        [JsonProperty(PropertyName = "isOatConfirmDeliverySchedule")]
        public bool IsOatConfirmDeliverySchedule { get; set; }
    }
}
