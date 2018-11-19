using System;

namespace Mi9.Store.Entities.Entities
{
    public class ZReadTenderTypeEntity
    {
        public short RegisterId { get; set; }

        public int TranNumber { get; set; }

        public DateTime TranDate { get; set; }

        public byte TenderCode { get; set; }

        public short ZTenderCount { get; set; }

        public decimal ZTenderAmt { get; set; }

        public decimal ZForeignAmt { get; set; }

        public byte CollectPer { get; set; }

        public virtual ZReadEntity ZRead { get; set; }
    }
}