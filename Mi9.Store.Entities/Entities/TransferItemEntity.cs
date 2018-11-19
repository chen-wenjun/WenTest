namespace Mi9.Store.Entities.Entities
{
    public class TransferItemEntity
    {
        public string TransferNumber { get; set; }

        public short? SourceStore { get; set; }

        public long SKU { get; set; }

        public string ProductStatus { get; set; }

        public decimal SourceStoreQtyAvail { get; set; }

        public decimal ReqStoreQtyAvail { get; set; }

        public decimal PendingQty { get; set; }

        public decimal QtyRequested { get; set; }

        public decimal QtyShipped { get; set; }

        public decimal QtyReceived { get; set; }

        public decimal QtyDamage { get; set; } 

        public decimal SourceStoreCost { get; set; }

        public decimal RequestStoreCost { get; set; }

        public decimal SourceStoreRetail { get; set; }

        public decimal RequestStoreRetail { get; set; }

        public virtual ItemSkuEntity ItemSku { get; set; }

        public virtual TransferEntity Transfer { get; set; }

        public virtual StoreEntity Store { get; set; }

        //TODO: Remember calculate these fields and remove them in here
        //[NotMapped]
        //public decimal ReceivedQuantity { get; set; }

        //[NotMapped]
        //public decimal DamagedQuantity { get; set; }
    }
}