using System;
using System.Collections.Generic;

namespace Mi9.Store.Entities.Entities
{
    public class CshOffBalEntity
    {
        public int RegOrEmplId { get; set; }
        public int EmployeeNo { get; set; }
        public byte Drawer { get; set; }
        public DateTime LoanDate { get; set; }
        public TimeSpan LoanTime { get; set; }
        public byte CollectPer { get; set; }
        public bool Origin { get; set; }
        public bool LoanType { get; set; }
        public Int16 ZReadsNumb { get; set; }
        public Int16 ZReadRegId { get; set; }
        public int ZReadTranNo { get; set; }
        public bool DrawerStatus { get; set; }
        public bool Posted { get; set; }
        public bool Communicated { get; set; }
        public DateTime EntryDate { get; set; }
        public Int16 Sequence { get; set; }

        public virtual ICollection<CshOffBalDetailEntity> CshOffBalDetails { get; set; }

        //public CshOffBalEntity()
        //{
        //    CshOffBalDetails = new List<CshOffBalDetailEntity>();
        //}
    }
}
