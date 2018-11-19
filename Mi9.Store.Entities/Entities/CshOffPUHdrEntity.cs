using System;
using System.Collections.Generic;

namespace Mi9.Store.Entities.Entities
{
    public class CshOffPUHdrEntity
    {
        public int RegOrEmplId { get; set; }
        public int EmployeeNo { get; set; }
        public byte Drawer { get; set; }
        public DateTime PickUpDate { get; set; }
        public TimeSpan PickUpTime { get; set; }
        public byte CollectPer { get; set; }
        public bool Origin { get; set; }
        public bool LoanType { get; set; }
        public int RegisterID { get; set; }
        public int TranNumber { get; set; }
        public DateTime OpenDate { get; set; }

        public virtual ICollection<CshOffPUDtlEntity> CshOffPUDtls { get; set; }
    }
}

