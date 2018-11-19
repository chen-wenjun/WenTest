namespace Mi9.Store.Entities.Entities
{
    public class SkuKitItemEntity
    {
        public long KitNumber { get; set; }

        public long SKU { get; set; }

        public decimal Quantity { get; set; }

        public decimal Price { get; set; }

        public virtual SkuKitEntity KitHeader { get; set; }

        public virtual ItemSkuEntity ItemSKU { get; set; }
    }
}
