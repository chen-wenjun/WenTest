namespace Mi9.Store.Entities.Entities
{
    public class SccRequirementEntity
    {
        public long Id { get; set; }

        public bool IsRequiredAdvanceDeposit { get; set; }
        public int? AmountAdvanceDeposit { get; set; }
        public bool IsStoreConfirmAdvanceDeposit { get; set; }
        public bool IsOatConfirmAdvanceDeposit { get; set; }

        public bool IsRequiredCustomerPo { get; set; }
        public bool IsStoreConfirmCustomerPo { get; set; }
        public bool IsOatConfirmCustomerPo { get; set; }

        public bool IsRequiredDeliverySchedule { get; set; }
        public bool IsStoreConfirmDeliverySchedule { get; set; }
        public bool IsOatConfirmDeliverySchedule { get; set; }

        public virtual PricingAgreementEntity Agreement { get; set; }
    }
}
