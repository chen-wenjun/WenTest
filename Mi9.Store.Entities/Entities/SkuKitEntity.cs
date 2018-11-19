using System;
using System.Collections.Generic;

namespace Mi9.Store.Entities.Entities
{
    public class SkuKitEntity
    {
        public long KitNumber { get; set; }

        public DateTime? SetupDate { get; set; }

        public bool ExplodeKit { get; set; }

        public decimal? KitPrice { get; set; }

        public virtual ICollection<SkuKitItemEntity> KitItems { get; set; }
    }
}
