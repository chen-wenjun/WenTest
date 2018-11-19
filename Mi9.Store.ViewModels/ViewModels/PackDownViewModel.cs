using System;

namespace Mi9.Store.ViewModels.ViewModels
{
    public class PackDownViewModel
    {
        public decimal OnHand { get; set; }
        public decimal OnOrder { get; set; }
        public decimal DistroOrder { get; set; }
        public Byte VendorPack { get; set; }
        public int User { get; set; }
        public string BayOver { get; set; }
        public string BayHome { get; set; }
        public int Days { get; set; }
        public string Status { get; set; }
        public string Action { get; set; }
        public DateTime Date { get; set; }
    }
}
