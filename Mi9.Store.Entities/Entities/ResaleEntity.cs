
namespace Mi9.Store.Entities.Entities
{
    using System.ComponentModel.DataAnnotations;

    /// <summary>
    /// The resale entity.
    /// </summary>
    public class ResaleEntity
    {
        /// <summary>
        /// Gets or sets the id.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Gets or sets the purchase order id.
        /// </summary>
        [StringLength(11)]
        public string SpecialPurchaseOrderId { get; set; }

        /// <summary>
        /// Gets or sets the order id.
        /// </summary>
        public int ResaleOrderId { get; set; }

        /// <summary>
        /// Gets or sets the sku.
        /// </summary>
        public long SkuId { get; set; }

        /// <summary>
        /// Gets or sets the sku description.
        /// </summary>
        public string SkuDescription { get; set; }

        /// <summary>
        /// Gets or sets the count.
        /// </summary>
        public decimal Count { get; set; }

        /// <summary>
        /// Gets or sets the special order.
        /// </summary>
        public SpecialOrderEntity SpecialPurchaseOrder { get; set; }

        /// <summary>
        /// Gets or sets the resale order.
        /// </summary>
        public OrderEntity ResaleOrder { get; set; }

        /// <summary>
        /// Gets or sets the sku.
        /// </summary>
        public ItemSkuEntity Sku { get; set; }
    }
}
