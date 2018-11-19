namespace Mi9.Store.Entities.Entities
{
    public class CmDepositDetailEntity
    {
        public long DepositNumber { get; set; }

        public int TenderId { get; set; }

        public int CurrencyId { get; set; }

        public int TenderCount { get; set; }

        public decimal TenderRate { get; set; }

        public decimal TenderAmount { get; set; }

        public virtual CmDepositHeaderEntity Deposit { get; set; }
    }
}
