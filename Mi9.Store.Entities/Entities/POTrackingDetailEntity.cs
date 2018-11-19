using System;

namespace Mi9.Store.Entities.Entities
{
    public class PoTrackingDetailEntity
    {
        public long Id { get; set; }
        public string PONumber { get; set; }
        public string StateId { get; set; }
        public DateTime? EstimatedDate { get; set; }
        public DateTime? Date { get; set; }

        public virtual PoTrackingEntryEntity PoTrackingEntry { get; set; }
        public virtual PoTrackingStateEntity State { get; set; }
    }
}
