namespace Mi9.Store.Entities.Entities
{
    public class PromotionItemEntity
    {
        public long Sku { get; set; }

        public int PromotionId { get; set; }

        public short SequenceNumber { get; set; }

        public decimal? NormalPrice { get; set; }

        public virtual PromotionEntity Promotion { get; set; }

        public virtual ItemSkuEntity ItemSku { get; set; }

        public byte PromoType { get; set; }
    }
}