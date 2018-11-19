namespace Mi9.Store.Entities.Entities
{
    public class CmPickupDetailEntity
    {
        public int Id { get; set; }
        public int PickupHdrId { get; set; }
        public int TenderId { get; set; }
        public int CurrencyId { get; set; }
        public decimal TenderAmount { get; set; }
        public int TenderCount { get; set; }
        public decimal Rate { get; set; }
        
        public virtual CmPickupHeaderEntity PickupHeader { get; set; }
        public virtual CmTenderEntity Tender { get; set; }
        public virtual CmCurrencyEntity Currency { get; set; }
    }
}
