using System;

namespace Mi9.Store.Entities.Entities
{
    public class CshOffSafeEntity
    {
        public int EmployeeNo { get; set; }
        public DateTime? SetupDate { get; set; }
        public TimeSpan SetupTime { get; set; }
        public decimal TenderAmount { get; set; }
        public int TenderCount { get; set; }
        public Int16 TenderCode { get; set; }
    }
}
