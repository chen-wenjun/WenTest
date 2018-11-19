using System.ComponentModel.DataAnnotations.Schema;

namespace Mi9.Store.Entities.Entities
{
    /// <summary>
    /// The SKU request item entity.
    /// </summary>
    public class SkuRequestItemEntity
    {
        /// <summary>
        /// Gets or sets the id.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Gets or sets the request price.
        /// </summary>
        public decimal RequestPrice { get; set; }

        /// <summary>
        /// Gets or sets the last price.
        /// </summary>
        public decimal LastPrice { get; set; }
        
        /// <summary>
        /// Gets or sets the authorization level.
        /// </summary>
        public string AuthorizationLevel { get; set; }

        /// <summary>
        /// Gets or sets the status.
        /// </summary>
        public string Status { get; set; }

        /// <summary>
        /// Gets or sets the SPV id.
        /// </summary>
        public int SPVId { get; set; }

        /// <summary>
        /// Gets the requested margin.
        /// </summary>
        [NotMapped]
        public decimal RequestedMargin
        {
            get
            {
                if (SKU == null || SKU.Cost == null || RequestPrice == 0)
                {
                    return 0;
                }

                return RequestPrice - SKU.Cost.Value;
            }
        }

        /// <summary>
        /// Gets the requested margin percent.
        /// </summary>
        [NotMapped]
        public decimal RequestedMarginPercent
        {
            get
            {
                if (SKU == null || SKU.Cost == null || RequestPrice == 0)
                {
                    return 0;
                }

                return (RequestPrice - SKU.Cost.Value) / RequestPrice * 100;
            }
        }

        /// <summary>
        /// Gets the average cost.
        /// </summary>
        [NotMapped]
        public decimal AverageCost
        {
            get
            {
                if (SKU == null || !SKU.Cost.HasValue)
                {
                    return 0;
                }

                return SKU.Cost.Value;
            }
        }

        /// <summary>
        /// Gets or sets the skuid.
        /// </summary>
        public long SKUID { get; set; }

        /// <summary>
        /// Gets or sets the order sequence number.
        /// </summary>
        public short OrdSeqNumber { get; set; }

        /// <summary>
        /// Gets or sets the sku.
        /// </summary>
        public virtual ItemSkuEntity SKU { get; set; }

        /// <summary>
        /// Gets or sets the special price request.
        /// </summary>
        public virtual SpecialPriceRequestEntity SpecialPriceRequest { get; set; }
    }
}
