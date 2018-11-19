using System;

namespace Mi9.Store.Entities.Entities
{
    public class CshOffPUDtlEntity
    {
        public decimal TenderAmount { get; set; }
        public decimal Rate { get; set; }
        public decimal Amount { get; set; }
        public Int16 TenderCount { get; set; }
        public int RegOrEmplId { get; set; }
        public byte Drawer { get; set; }
        public DateTime PickUpDate { get; set; }
        public TimeSpan PickUpTime { get; set; }
        public bool LoanType { get; set; }
        public DateTime OpenDate { get; set; }
        public byte TenderCode { get; set; }

        public virtual CshOffPUHdrEntity CshOffPUHeader { get; set; }
    }
}

