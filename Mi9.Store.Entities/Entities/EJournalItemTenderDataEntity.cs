using System;

namespace Mi9.Store.Entities.Entities
{
    public class EJournalItemTenderDataEntity
    {
        public int TranNumber { get; set; }

        public DateTime TranDate { get; set; }

        public short RegisterId { get; set; }

        public short SigSequence { get; set; }

        public byte Sequence { get; set; }

        public string MiscNumber { get; set; }

        public virtual EJournalItemTenderEntity EJournalTender { get; set; }
    }
}