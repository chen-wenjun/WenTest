using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Mi9.Store.Entities.Entities
{
    /// <summary>
    /// Consist the common settings for working with po orders
    /// </summary>
    [Table("POControl")]
    public class PurchaseOrderControlEntity
    {
        /// <summary>
        /// Identifier
        /// </summary>
        [Key, Column("IDX_FIELD")]
        public bool Id { get; set; }

        /// <summary>
        /// Quantity of days that used to initial calculate: cancellationDate = deliveryDate + DropDeadDays
        /// </summary>
        public byte DropDeadDays { get; set; }
    }
}