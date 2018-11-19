using System;

namespace Mi9.Store.Entities.Entities
{
    public class CshOffBalDetailEntity
    {
        public int RegOrEmplId { get; set; }
        public byte Drawer { get; set; }
        public DateTime LoanDate { get; set; }
        public bool LoanType { get; set; }
        public Int16 Sequence { get; set; }
        public byte TenderCode { get; set; }
        public decimal ZTenderAmt { get; set; }
        public Int16 ZMediaCount { get; set; }
        public decimal ActTenderAmt { get; set; }
        public Int16 ActMediaCnt { get; set; }
        public decimal OverShortAmt { get; set; }
        public bool OverShortSrc { get; set; }
        public Int16 OverShortCnt { get; set; }

        public virtual CshOffBalEntity CshOffBalance { get; set; }
    }
}
