using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Mi9.Store.Entities.Entities
{
    /// <summary>
    /// The inventory adjustment entity.
    /// </summary>
    [Table("InvAdjLog")]
    public class InventoryAdjustmentEntity
    {
        [Key, Column("TranDate", Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public DateTime TransactionDate { get; set; }

        [Key, Column("TranTime", Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public TimeSpan TransactionTime { get; set; }

        [Key, Column(Order = 2), DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int AutoSequence { get; set; }

        [Column("TranNumber")]
        public long TransactionNumber { get; set; }

        [Column("QuantityAdj")]
        public decimal QuantityAdjusted { get; set; }

        [Column("OldQtyOnHand")]
        public decimal CurrentAvailable { get; set; }

        public decimal RetailPrice { get; set; }

        public decimal Cost { get; set; }

        [Column("NewAverCost")]
        public decimal NewCost { get; set; }

        [Column("OldAverCost")]
        public decimal OldCost { get; set; }

        [Column("SKUAdjusted")]
        public long SkuId { get; set; }

        public byte ReasonCode { get; set; }

        [Column("QuantityReplace")]
        public bool QuantityReplace { get; set; }

        [Column("Remarks")]
        public string Remarks { get; set; }

        [Column("RecStatus")]
        public byte Status { get; set; }

        [Column("EmployeeNo")]
        public int EmployeeId { get; set; }

        [Column("TranType")]
        public byte TranType { get; set; }

        [NotMapped]
        public string FirstName { get; set; }

        [ForeignKey("SkuId")]
        public ItemSkuEntity Sku { get; set; }

        [Column("ConvertSign")]
        public string ConvertSign { get; set; }

        [Column("VendorID")]
        public string VendorID { get; set; }

        [Column("VendorSuffix")]
        public byte? VendorSuffix { get; set; }
    }
}