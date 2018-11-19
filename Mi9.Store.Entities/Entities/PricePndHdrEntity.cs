using System;
using System.Collections.Generic;

namespace Mi9.Store.Entities.Entities
{
    public class PricePndHdrEntity
    {
        public DateTime? Effective { get; set; }
        public byte ChangeType { get; set; }
        public DateTime? AppliedDate { get; set; }
        public int BatchNumber { get; set; }
        public short SequenceNo { get; set; }
        public virtual ICollection<PricePndDtlEntity> PricePndDetail { get; set; }
    }
}
