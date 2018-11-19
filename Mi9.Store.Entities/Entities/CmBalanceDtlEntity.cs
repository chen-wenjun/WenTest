namespace Mi9.Store.Entities.Entities
{
    public class CmBalanceDtlEntity
    {
        public int Id { get; set; } 
        public int BalanceHdrId { get; set; } 
        public int TenderId { get; set; } 
        public int CurrencyId { get; set; }
        public decimal ActualTenderAmnt { get; set; }
        public int ActualTenderCnt { get; set; }
        public decimal ZReadsAmnt { get; set; }
        public int ZReadsCnt { get; set; }
        
        public virtual CmBalanceHdrEntity CmCashBalanceHeader { get; set; }
        public virtual CmTenderEntity Tender { get; set; }
        public virtual CmCurrencyEntity Currency { get; set; }
    }
}
