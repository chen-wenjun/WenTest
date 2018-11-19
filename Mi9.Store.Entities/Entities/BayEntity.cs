using System;
using System.Collections.Generic;

namespace Mi9.Store.Entities.Entities
{
    public class BayEntity
    {
        public int Id { get; set; }
        public string ZoneId { get; set; }
        public string BayNumber { get; set; }
        public string LabelDirection { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreationDate { get; set; }
        public int? UpdatedBy { get; set; }
        public DateTime? UpdateDate { get; set; }
        public virtual ICollection<PackDownEntity> PackDowns { get; set; }
        public ICollection<PhyInvPreCountSchedEntity> PhyInvPreCountScheds { get; set; }
        public virtual ICollection<SKULocationEntity> SkuLocations { get; set; }
        public virtual ZoneEntity Zone { get; set; }
    }
}
