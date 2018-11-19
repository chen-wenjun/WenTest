using System;
using System.ComponentModel.DataAnnotations;

namespace Mi9.Store.Entities.Entities
{
    public class CshOffLoanEntity
    {
        public int RegOrEmplId { get; set; }
        public int EmployeeNo { get; set; }
        public byte Drawer { get; set; }
        public DateTime LoanDate { get; set; }
        public TimeSpan LoanTime { get; set; }
        public byte CollectPer { get; set; }
        public bool Origin { get; set; }
        public bool LoanEntry { get; set; }
        public bool LoanType { get; set; }
        public decimal LoanAmount { get; set; }
        public int RegisterId { get; set; }
        public int TranNumber { get; set; }
        public DateTime OpenDate { get; set; }
        public int AutoSequence { get; set; }
    }

    
}
