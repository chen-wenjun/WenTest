namespace Mi9.Store.Entities.Entities
{
    public class WithdrawalDenominationEntity
    {
        public long Id { get; set; }
        
        public int WithdrawalId { get; set; }

        public virtual WithdrawalEntity Withdrawal { get; set; }

        public int DenominationId { get; set; }

        public virtual DenominationEntity Denomination { get; set; }

        public int Quantity { get; set; }

        public decimal TotalPrice { get; set; }

        public string Description { get; set; }

        public int? TranNumber { get; set; }
    }
}