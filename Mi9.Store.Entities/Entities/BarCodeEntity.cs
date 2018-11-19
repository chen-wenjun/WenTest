using System;

namespace Mi9.Store.Entities.Entities
{
    public class BarCodeEntity
    {
        public string Id { get; set; }

        public bool? IsSystemGenerated { get; set; }

        public string POSDescription { get; set; }

        public short? AtForQuantity { get; set; }

        public DateTime? AddedDate { get; set; }

        public DateTime? LastActivityDate { get; set; }

        public decimal? AmountOffPct { get; set; }
        
        public string UPCOrigin { get; set; }

        public decimal? RetailPrice { get; set; }

        public bool Type { get; set; }

        public string UomType { get; set; }

        public decimal? AmountOff { get; set; }
        
        public long SKUId { get; set; }

        public virtual ItemSkuEntity ItemSKU { get; set; }
    }
}