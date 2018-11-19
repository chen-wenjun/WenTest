using System;

namespace Mi9.Store.Entities.Entities
{
    public class PoTrackingLogEntity
    {
        public long Id { get; set; }
        public string PONumber { get; set; }
        public string TypeId { get; set; }
        public string ContactName { get; set; }
        public string StateId { get; set; }
        public string Notes { get; set; }
        public DateTime Date { get; set; }
        public string UserPayrollId { get; set; }

        public virtual PoTrackingEntryEntity PoTrackingEntry { get; set; }
        public virtual PoTrackingLogTypeEntity LogType { get; set; }
        public virtual PoTrackingStateEntity State { get; set; }
    }
}
