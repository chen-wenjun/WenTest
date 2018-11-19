namespace Mi9.Store.Entities.Entities
{
    public class ItemVendorEntity
    {
        public long Sku { get; set; }

        public string VendorId { get; set; }

        public byte VendorSuffix { get; set; }

        public bool LeadPeriod { get; set; }

        public short? LeadTime { get; set; }

        public bool VendMarked { get; set; }

        public string VendUom { get; set; }

        public short VendUomQty { get; set; }

        public bool BrokenPack { get; set; }

        public int? MinOrdQty { get; set; }

        public decimal? Weight { get; set; }

        public string VendorSku { get; set; }

        public decimal? CollectCost { get; set; }

        public decimal? PrepaidCost { get; set; }

        public decimal? ItemHeight { get; set; }

        public decimal? ItemWidth { get; set; }

        public decimal? ItemDepth { get; set; }

        public virtual VendorEntity Vendor { get; set; }

        public virtual ItemSkuEntity ItemSku { get; set; }
    }
}