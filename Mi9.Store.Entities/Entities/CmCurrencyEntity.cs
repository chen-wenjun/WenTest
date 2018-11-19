using System.Collections.Generic;

namespace Mi9.Store.Entities.Entities
{
    public class CmCurrencyEntity
    {
        public int Id { get; set; }
        public string Symbol { get; set; }
        public string Code { get; set; }
        public string Description { get; set; }
        public decimal Rate { get; set; }
        public bool IsBaseCurrency { get; set; }

        public virtual ICollection<CmTenderCurrencyDenominationEntity> CmTenderCurrencyDenominations { get; set; }
    }
}
