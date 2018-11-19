using System;

namespace Mi9.Store.ViewModels.ViewModels
{
    public class SKULocationViewModel
    {
        public int? Id { get; set; }
        public long SKU { get; set; }
        public int BayId { get; set; }
        public string Level { get; set; }
        public string CreatedFrom { get; set; }
        public bool Deleted { get; set; }
        public DateTime? DateAmended { get; set; }
        public int? AmendedBy { get; set; }
        public int Amount { get; set; }
        public int IsSuitable { get; set; }
        public BayViewModel Bay { get; set; }
        public bool Auditable { get; set; }
    }
}
