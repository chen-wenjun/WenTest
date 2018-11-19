using System;

namespace Mi9.Store.Entities.Entities
{
    public class CshOffAdjustEntity
    {
        public int EmployeeNo { get; set; }
        public string AdjustReason { get; set; }
        public DateTime ManDate { get; set; }
        public TimeSpan ManTime { get; set; }
        public byte CollectPer { get; set; }
        public byte TenderCode { get; set; }
        public decimal TenderAmount { get; set; }
        public int TenderCount { get; set; }
        public decimal Rate { get; set; }
        public decimal Amount { get; set; }
        public decimal PrevSafeAmt { get; set; }
        public int PrevTndrCnt { get; set; }
        public int AutoSequence { get; set; }
    }
}
