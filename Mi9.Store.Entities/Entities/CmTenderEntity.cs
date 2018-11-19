using System.Collections.Generic;

namespace Mi9.Store.Entities.Entities
{
    public class CmTenderEntity
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public bool IsCash { get; set; }
        public bool SafeTender { get; set; }

        public virtual ICollection<CmTenderCurrencyDenominationEntity> CmTenderCurrencyDenominations { get; set; }
    }
}
