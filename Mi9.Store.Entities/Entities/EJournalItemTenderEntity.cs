using System;
using System.Collections.Generic;

namespace Mi9.Store.Entities.Entities
{
    public class EJournalItemTenderEntity
    {
        public int TranNumber { get; set; }

        public DateTime TranDate { get; set; }

        public short RegisterId { get; set; }

        public short SigSequence { get; set; }

        public byte TenderCode { get; set; }

        public decimal TenderAmount { get; set; }

        public virtual ICollection<EJournalItemTenderDataEntity> TenderData { get; set; }

        public virtual EJournalItemEntity EJournalItem { get; set; }
    }
}