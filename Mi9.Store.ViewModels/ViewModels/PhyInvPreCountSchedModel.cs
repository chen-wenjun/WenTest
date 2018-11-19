using System;

namespace Mi9.Store.ViewModels.ViewModels
{
    public class PhyInvPreCountSchedModel
    {
        public int BayId { get; set; }
        public string Zone { get; set; }
        public Byte WeekNo { get; set; }
        public DateTime WeekStartDate { get; set; }
        public string Status { get; set; }
        public decimal RetailValue { get; set; }
    }
}
