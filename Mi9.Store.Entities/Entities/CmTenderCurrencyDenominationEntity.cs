using System;

namespace Mi9.Store.Entities.Entities
{
    public class CmTenderCurrencyDenominationEntity
    {
        public int TenderId { get; set; }
        public int CurrencyId { get; set; }
        public int DenominationId { get; set; }
        public byte? TenderCode { get; set; }

        public virtual CmTenderEntity Tender { get; set; }
        public virtual CmCurrencyEntity Currency { get; set; }
        public virtual CmDenominationEntity Denomination { get; set; }
    }
}
