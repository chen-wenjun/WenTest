using System;

namespace Mi9.Store.Entities.Entities
{
    public class PackDownEntity
    {
        public int Id { get; set; }
        public long HoleId { get; set; }
        public int BayId { get; set; }
        public BayEntity Bay { get; set; }
        public long SKU { get; set; }
        public string ProductType { get; set; }
        public string ProductStatus { get; set; }
        public string Display { get; set; }
        public short VendorPack { get; set; }
        public int? BayOverId { get; set; }
        public BayEntity BayOver { get; set; }
        public int OnHand { get; set; }
        public int OnOrder { get; set; }
        public string Action { get; set; }
        public Byte Status { get; set; }
        public DateTime DateOpened { get; set; }
        public int OpenBy { get; set; }
        public DateTime? DateClosed { get; set; }
        public int? CloseBy { get; set; }
        public ItemReplenEntity ItemReplen { get; set; }
        public ItemSkuEntity ItemPLU { get; set; }
    }
}
