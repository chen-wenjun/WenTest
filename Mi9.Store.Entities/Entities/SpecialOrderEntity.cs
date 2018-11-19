using System;
using System.Collections.Generic;

namespace Mi9.Store.Entities.Entities
{
    /// <summary>
    /// The purchase order state history.
    /// </summary>
    public class SpecialOrderEntity
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SpecialOrderEntity"/> class.
        /// </summary>
        public SpecialOrderEntity()
        {
            ConfirmUser = string.Empty;
            ReadyUser = string.Empty;
            TransitUser = string.Empty;
            ConfirmName = string.Empty;
            ReadyName = string.Empty;
            TransitName = string.Empty;
            ReceiveName = string.Empty;
            DeliveryName = string.Empty;
            Comment = string.Empty;
            Status = string.Empty;
            CancelStatus = string.Empty;
        }

        /// <summary>
        /// Gets or sets the purchase order number.
        /// </summary>
        public string PurchaseOrderNumber { get; set; }

        /// <summary>
        /// Gets or sets the order no.
        /// </summary>
        public int OrderNo { get; set; }

        /// <summary>
        /// Gets or sets the status.
        /// </summary>
        public string Status { get; set; }

        /// <summary>
        /// Gets or sets the cancel status.
        /// </summary>
        public string CancelStatus { get; set; }

        /// <summary>
        /// Gets or sets the confirm name.
        /// </summary>
        public string ConfirmName { get; set; }

        /// <summary>
        /// Gets or sets the transit name.
        /// </summary>
        public string TransitName { get; set; }

        /// <summary>
        /// Gets or sets the receive name.
        /// </summary>
        public string ReceiveName { get; set; }

        /// <summary>
        /// Gets or sets the ready name.
        /// </summary>
        public string ReadyName { get; set; }

        /// <summary>
        /// Gets or sets the delivery name.
        /// </summary>
        public string DeliveryName { get; set; }

        /// <summary>
        /// Gets or sets the e confirm date.
        /// </summary>
        public DateTime? EConfirmDate { get; set; }

        /// <summary>
        /// Gets or sets the e transit date.
        /// </summary>
        public DateTime? ETransitDate { get; set; }

        /// <summary>
        /// Gets or sets the e receive m date.
        /// </summary>
        public DateTime? EReceiveMDate { get; set; }

        /// <summary>
        /// Gets or sets the e receive s date.
        /// </summary>
        public DateTime? EReceiveSDate { get; set; }

        /// <summary>
        /// Gets or sets the e ready date.
        /// </summary>
        public DateTime? EReadyDate { get; set; }

        /// <summary>
        /// Gets or sets the e paid date.
        /// </summary>
        public DateTime? EPaidDate { get; set; }

        /// <summary>
        /// Gets or sets the e delivery date.
        /// </summary>
        public DateTime? EDeliveryDate { get; set; }

        /// <summary>
        /// Gets or sets the confirm date.
        /// </summary>
        public DateTime? ConfirmDate { get; set; }

        /// <summary>
        /// Gets or sets the transit date.
        /// </summary>
        public DateTime? TransitDate { get; set; }

        /// <summary>
        /// Gets or sets the receive m date.
        /// </summary>
        public DateTime? ReceiveMDate { get; set; }

        /// <summary>
        /// Gets or sets the receive s date.
        /// </summary>
        public DateTime? ReceiveSDate { get; set; }

        /// <summary>
        /// Gets or sets the ready date.
        /// </summary>
        public DateTime? ReadyDate { get; set; }

        /// <summary>
        /// Gets or sets the paid date.
        /// </summary>
        public DateTime? PaidDate { get; set; }

        /// <summary>
        /// Gets or sets the delivery date.
        /// </summary>
        public DateTime? DeliveryDate { get; set; }

        /// <summary>
        /// Gets or sets the confirm user.
        /// </summary>
        public string ConfirmUser { get; set; }

        /// <summary>
        /// Gets or sets the transit user.
        /// </summary>
        public string TransitUser { get; set; }

        /// <summary>
        /// Gets or sets the ready user.
        /// </summary>
        public string ReadyUser { get; set; }

        /// <summary>
        /// Gets or sets the comment.
        /// </summary>
        public string Comment { get; set; }

        /// <summary>
        /// Gets or sets the state id.
        /// </summary>
        public int? StateId { get; set; }

        /// <summary>
        /// Gets or sets the purchase order entity.
        /// </summary>
        public virtual PurchaseOrderEntity PurchaseOrderEntity { get; set; }

        /// <summary>
        /// Gets or sets the order entity.
        /// </summary>
        public virtual OrderEntity OrderEntity { get; set; }

        /// <summary>
        /// Gets or sets the state.
        /// </summary>
        public virtual PurchaseOrderStateHistoryStateEntity State { get; set; }

        /// <summary>
        /// Gets or sets the resales.
        /// </summary>
        public virtual ICollection<ResaleEntity> Resales { get; set; }
    }
}