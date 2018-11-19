namespace Mi9.Store.Entities.Entities
{
    public class ItemHistoryEntity
    {
        public long SKU { get; set; }

        public decimal YearToDateQuantity { get; set; }

        public virtual ItemSkuEntity ItemSku { get; set; }
    }
}
