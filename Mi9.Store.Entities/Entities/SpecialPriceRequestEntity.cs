using System;
using System.Collections.Generic;

namespace Mi9.Store.Entities.Entities
{
    /// <summary>
    /// The special price request entity.
    /// </summary>
    public class SpecialPriceRequestEntity
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SpecialPriceRequestEntity"/> class.
        /// </summary>
        public SpecialPriceRequestEntity()
        {
            Created = DateTime.UtcNow;
        }

        /// <summary>
        /// Gets or sets the id.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Gets or sets the reason.
        /// </summary>
        public string Reason { get; set; }

        /// <summary>
        /// Gets or sets the status.
        /// </summary>
        public string Status { get; set; }

        /// <summary>
        /// Gets or sets the creation date.
        /// </summary>
        public DateTime Created { get; set; }

        /// <summary>
        /// Gets or sets the order number.
        /// </summary>
        public int OrderNumber { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether need callback.
        /// </summary>
        public bool NeedCallback { get; set; }

        /// <summary>
        /// Gets or sets the order.
        /// </summary>
        public virtual OrderEntity Order { get; set; }

        /// <summary>
        /// Gets or set the status of the store approval
        /// </summary>
        public string StoreStatus { get; set; }

        /// <summary>
        /// Gets or set the status of the regional approval
        /// </summary>
        public string RegionalStatus { get; set; }

        /// <summary>
        /// Gets or set the status of the national approval
        /// </summary>
        public string NationalStatus { get; set; }

        /// <summary>
        /// Gets or sets the items.
        /// </summary>
        public virtual ICollection<SkuRequestItemEntity> Items { get; set; }
    }
}