using System;
using System.Collections.Generic;

namespace Mi9.Store.Entities.Entities
{
    public class CmBalanceHdrEntity
    {
        public int Id { get; set; } 
        public int OwnerId { get; set; } 
        public int EmployeeNo { get; set; } 
        public byte Drawer { get; set; } 
        public DateTime BalanceDate { get; set; } 
        public string BalancingMethod { get; set; }
        public DateTime ActiveDate { get; set; }
        
        public virtual ICollection<CmBalanceDtlEntity> BalanceDetails { get; set; }
    }
}
