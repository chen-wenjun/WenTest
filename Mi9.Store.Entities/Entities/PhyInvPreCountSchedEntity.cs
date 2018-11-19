using System;


namespace Mi9.Store.Entities.Entities
{
    public class PhyInvPreCountSchedEntity
    {
        public int Id { get; set; }
        public int BayId { get; set; }
        public int? CountId { get; set; }
        public string Status { get; set; }
        public Byte WeekNo { get; set; }
        public int? ClosedById { get; set; }
        public DateTime? CloseDate { get; set; }
        public int? AmendedById { get; set; }
        public DateTime? AmendedDate { get; set; }
        public DateTime? WeekStartDate { get; set; }
        public decimal RetailValue { get; set; }
        public virtual BayEntity Bay { get; set; }
    }
}
