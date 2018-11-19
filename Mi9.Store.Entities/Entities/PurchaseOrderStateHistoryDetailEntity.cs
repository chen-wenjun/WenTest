using System;

namespace Mi9.Store.Entities.Entities
{
    /// <summary>
    /// The purchase order state history detail.
    /// </summary>
    public class PurchaseOrderStateHistoryDetailEntity
    {
        /// <summary>
        /// Gets or sets the purchase number.
        /// </summary>
        public string PurchaseNumber { get; set; }

        /// <summary>
        /// Gets or sets the step.
        /// </summary>
        public long Step { get; set; }

        /// <summary>
        /// Gets or sets the title.
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// Gets or sets the e date.
        /// </summary>
        public DateTime EDate { get; set; }

        /// <summary>
        /// Gets or sets the r date.
        /// </summary>
        public DateTime RDate { get; set; }

        /// <summary>
        /// Gets or sets the state date.
        /// </summary>
        public DateTime StateDate { get; set; }

        /// <summary>
        /// Gets or sets the stat hour.
        /// </summary>
        public string StatHour { get; set; }

        /// <summary>
        /// Gets or sets the change user.
        /// </summary>
        public string ChangeUser { get; set; }

        /// <summary>
        /// Gets or sets the status.
        /// </summary>
        public string Status { get; set; }

        /// <summary>
        /// Gets or sets the type.
        /// </summary>
        public string Type { get; set; }

        /// <summary>
        /// Gets or sets the comment.
        /// </summary>
        public string Comment { get; set; }

        /// <summary>
        /// Gets or sets the state id.
        /// </summary>
        public int? StateId { get; set; }

        /// <summary>
        /// Gets or sets the purchase order.
        /// </summary>
        public virtual PurchaseOrderEntity PurchaseOrder { get; set; }

        /// <summary>
        /// Gets or sets the state.
        /// </summary>
        public virtual PurchaseOrderStateHistoryStateEntity State { get; set; }
    }
}
