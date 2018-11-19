using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Mi9.Store.Entities.Entities
{
   
    public class ReturnToVendorItemEntity
    {
       
        public long RTVNumber { get; set; }

        public long SKU { get; set; }

        public byte ReasonCode { get; set; }

        public decimal QtyRetn { get; set; }

        public decimal AvgCost { get; set; }

        public decimal RetailPrice { get; set; }

        public string InventoryAdjustType { get; set; }

        public string Notes { get; set; }

        public string UPC { get; set; }

        public decimal QtyReceive { get; set; }

        //public decimal LastQty { get; set; }

        public DateTime? Updated { get; set; }

        //TODO: Define in the ViewModel layer
        [NotMapped]
        public bool Status { get; set; }

        public virtual ItemSkuEntity ItemSku { get; set; }

        public virtual ReturnToVendorEntity ReturnToVendor { get; set; }
    }
}
