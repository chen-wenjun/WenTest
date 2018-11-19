using System;
using System.Collections.Generic;

namespace Mi9.Store.Entities.Entities
{
    /// <summary>
    /// The scc item entity.
    /// </summary>
    public class SccItemEntity
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SccItemEntity"/> class.
        /// </summary>
        public SccItemEntity()
        {
            ItemStatus = "New";
        }

        /// <summary>
        /// Gets or sets the id.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Gets or sets the quantity required.
        /// </summary>
        public int QuantityRequired { get; set; }

        /// <summary>
        /// Gets or sets the quantity sold.
        /// </summary>
        public int QuantitySold { get; set; }

        /// <summary>
        /// Gets or sets the target price.
        /// </summary>
        public decimal TargetPrice { get; set; }

        /// <summary>
        /// Gets or sets the pro price.
        /// </summary>
        public decimal? ProPrice { get; set; }

        /// <summary>
        /// Gets or sets the extended price.
        /// </summary>
        public decimal ExtendedPrice { get; set; }

        /// <summary>
        /// Gets or sets the item status.
        /// </summary>
        public string ItemStatus { get; set; }

        /// <summary>
        /// Gets or sets the item Remarks.
        /// </summary>
        public string ItemRemarks { get; set; }

        /// <summary>
        /// Gets or sets the item Line status comments.
        /// </summary>
        public string StoreRemarks { get; set; }

        /// <summary>
        /// Gets or sets the sku id.
        /// </summary>
        public long SkuId { get; set; }

        /// <summary>
        /// Gets or sets the proposal sku id.
        /// </summary>
        public long? ProposalSkuId { get; set; }

        /// <summary>
        /// Gets or sets the follow up date.
        /// </summary>
        public DateTime? FollowUpDate { get; set; }

        /// <summary>
        /// Gets or sets the item sku.
        /// </summary>
        public virtual ItemSkuEntity ItemSKU { get; set; }

        /// <summary>
        /// Gets or sets the proposal item sku.
        /// </summary>
        public virtual ItemSkuEntity ProposalItemSku { get; set; }
        
        public virtual string SupportDescription { get; set; }


        /// <summary>
        /// Gets or sets the competitors.
        /// </summary>
        public virtual ICollection<SccItemCompetitorEntity> Competitors { get; set; }

        /// <summary>
        /// Gets or sets the agreement id.
        /// </summary>
        public long AgreementId { get; set; }

        /// <summary>
        /// Gets or sets the pricing agreement.
        /// </summary>
        public virtual PricingAgreementEntity PricingAgreement { get; set; }

    }
}
