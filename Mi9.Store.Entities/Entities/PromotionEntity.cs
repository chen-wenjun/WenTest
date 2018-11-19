using System;
using System.Collections.Generic;

namespace Mi9.Store.Entities.Entities
{
    public class PromotionEntity
    {
        public int PromotionId { get; set; }

        public DateTime StartDate { get; set; }

        public DateTime? EndDate { get; set; }

        public TimeSpan? StartTime { get; set; }

        public TimeSpan? EndTime { get; set; }

        public short SequenceNumber { get; set; }

        public byte PromoType { get; set; }

        public virtual ICollection<PromotionItemEntity> PromitionItems { get; set; }
    }
}