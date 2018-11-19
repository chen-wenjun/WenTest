using System.Collections.Generic;

namespace Mi9.Store.Entities.Entities
{
    /// <summary>
    /// The category entity.
    /// </summary>
    public class CategoryEntity
    {
        /// <summary>
        /// Gets or sets the department id.
        /// </summary>
        public short DepartmentId { get; set; }

        /// <summary>
        /// Gets or sets the class id.
        /// </summary>
        public short ClassId { get; set; }

        /// <summary>
        /// Gets or sets the sub class.
        /// </summary>
        public short SubClass { get; set; }

        public string CateDesc { get; set; }

        public decimal? LowPercent { get; set; }

        // TODO: validate that it's not smaller than LowerPercent
        public decimal? HiPercent { get; set; }

        public short? MinAmtGP { get; set; }

        public int? Cycle2Total { get; set; }

        public int? Cycle4Total { get; set; }

        public int? Cycle12Total { get; set; }

        public decimal? SOGMGuide { get; set; }

        /// <summary>
        /// Gets or sets the purchase order items.
        /// </summary>
        public ICollection<PurchaseOrderItemEntity> PurchaseOrderItems { get; set; }
    }
}
