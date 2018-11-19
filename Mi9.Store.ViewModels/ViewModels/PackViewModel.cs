using System;

namespace Mi9.Store.ViewModels.ViewModels
{
    public class PackViewModel
    {
        public int? Id { get; set; }

        public int BayId { get; set; }

        public long SKU { get; set; }

        public string ProductType { get; set; }

        public decimal? Available { get; set; }

        // Added //

        public long? HoleId { get; set; }

        public string BayOverIdString { get; set; }

        public BayViewModel Bay { get; set; }

        public decimal? Price { get; set; }

        public decimal? Promo { get; set; }

        public string VelocityCode { get; set; }

        public string Description { get; set; }

        public string TypePdn { get; set; }

        // Added //

        public string ProductStatus { get; set; }

        public string Display { get; set; }

        public short VendorPack { get; set; }

        public int? BayOverId { get; set; }

        public int OnHand { get; set; }

        public int OnOrder { get; set; }

        public string Action { get; set; }

        public DateTime DateOpened { get; set; }

        public int? OpenBy { get; set; }

        public DateTime? DateClosed { get; set; }

        public int? CloseBy { get; set; }
    }
}
