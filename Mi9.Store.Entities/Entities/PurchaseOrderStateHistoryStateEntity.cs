using System.Collections.Generic;

namespace Mi9.Store.Entities.Entities
{
    /// <summary>
    /// The purchase order state history state.
    /// </summary>
    public class PurchaseOrderStateHistoryStateEntity
    {
        /// <summary>
        /// Gets or sets the id.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Gets or sets the spanish code.
        /// </summary>
        public string EspCode { get; set; }

        /// <summary>
        /// Gets or sets the english code.
        /// </summary>
        public string EngCode { get; set; }

        /// <summary>
        /// Gets or sets the description.
        /// </summary>
        public string Description { get; set; }

        ///// <summary>
        ///// Gets or sets the purchase order entities.
        ///// </summary>
        //public virtual ICollection<PurchaseOrderEntity> PurchaseOrderEntities { get; set; }

        /// <summary>
        /// Gets or sets the purchase order state histories.
        /// </summary>
        public virtual ICollection<SpecialOrderEntity> PurchaseOrderStateHistories { get; set; }

        /// <summary>
        /// Gets or sets the purchase order state history details.
        /// </summary>
        public virtual ICollection<PurchaseOrderStateHistoryDetailEntity> PurchaseOrderStateHistoryDetails { get; set; }
    }
}
