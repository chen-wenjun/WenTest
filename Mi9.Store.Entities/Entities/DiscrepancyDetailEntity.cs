using System.Collections.Generic;

namespace Mi9.Store.Entities.Entities
{
    public class DiscrepancyDetailEntity
    {
        public long Id { get; set; }

        public long DiscrepancyNumber { get; set;}

        public long SKU { get; set;}

        public string PalletId { get; set; }

        public string Type { get; set; }

        public int QuantityShipped { get; set;}

        public int QuantityDisputed { get; set; }

        public decimal UnitCost { get; set;}

        public decimal RetailPrice { get; set; }

        public string Notes { get; set; }

        public int? Action { get; set; }

        public virtual ICollection<DiscrepancyAttachmentEntity> Attachments { get; set; }

        public virtual DiscrepancyEntity Discrepancy { get; set; }

        public virtual ItemSkuEntity ItemSkuEntity { get; set; }

        public virtual PalletEntity Pallet { get; set; }
    }
}
