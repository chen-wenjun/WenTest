using System;
using System.Collections.Generic;

namespace Mi9.Store.Entities.Entities
{
    public class CmPickupHeaderEntity
    {
        public int Id { get; set; }
        public string BalancingMethod { get; set; }
        public int OwnerId { get; set; }
        public byte Drawer { get; set; }
        public DateTime CreatedOn { get; set; }
        public int CreatedBy { get; set; }
        public DateTime ActiveDate { get; set; }

        public virtual ICollection<CmPickupDetailEntity> PickupDetails { get; set; }
    }
}
