using System;

namespace Mi9.Store.Entities.Entities
{
    public class CmLoanEntity
    {
        public int Id { get; set; }
        public string Type { get; set; }
        public string BalancingMethod { get; set; }
        public int OwnerId { get; set; }
        public byte Drawer { get; set; }
        public decimal Amount { get; set; }
        public DateTime CreatedOn { get; set; }
        public int CreatedBy { get; set; }
        public DateTime ActiveDate { get; set; }
    }
}
