namespace Mi9.Store.ViewModels.ViewModels
{
    public class OpenHoleFirstPhoneViewModel
    {
        public bool HasHole { get; set; }

        public string HoleType { get; set; }

        public string HoleDateOpened { get; set; }

        public string ZoneId { get; set; }

        public int BayId { get; set; }

        public decimal Price { get; set; }

        public long SKU { get; set; }

        public string UOM { get; set; }

        public string SKUDescription { get; set; }

        public string Type { get; set;  }

        public string Status { get; set; }

        public int Stock { get; set; }

        public decimal OnHand { get; set; }
        
        public decimal OnOrder { get; set; }
        
        public int VendorPack { get; set; }

        public decimal Remate { get; set; }

    }
}