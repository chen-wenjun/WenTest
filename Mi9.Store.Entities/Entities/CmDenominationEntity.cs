using System.Collections.Generic;

namespace Mi9.Store.Entities.Entities
{
    public class CmDenominationEntity
    {
        public int Id { get; set; }
        public decimal Value { get; set; }

        public virtual ICollection<CmTenderCurrencyDenominationEntity> CmTenderCurrencyDenominations { get; set; }
    }
}
