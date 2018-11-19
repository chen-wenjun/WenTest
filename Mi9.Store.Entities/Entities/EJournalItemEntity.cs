using System;
using System.Collections.Generic;

namespace Mi9.Store.Entities.Entities
{
    public class EJournalItemEntity
    {
        public EJournalItemEntity()
        {
            RecType = "N";
            SoldFirstName = string.Empty;
            SoldLastName = string.Empty;
            SoldMidInit = string.Empty;
        }

        public int TranNumber { get; set; }

        public DateTime TranDate { get; set; }

        public TimeSpan TranTime { get; set; }

        public short RegisterId { get; set; }

        public int EmployeeNo { get; set; }

        public int DocumentNumber { get; set; }

        public string RecType { get; set; }

        public decimal TxnTotal { get; set; }

        public string SoldLastName { get; set; }

        public string SoldFirstName { get; set; }

        public string SoldMidInit { get; set; }

        public int Sequence { get; set; }

        public byte Drawer { get; set; }

        public DateTime SystemDate { get; set; }

        public virtual ICollection<EJournalItemTenderEntity> Tenders { get; set; }
    }
}