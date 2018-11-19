using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Mi9.Store.Entities.Entities
{    
    /// <summary>
    /// The pro price entity.
    /// </summary>
    public class ProPriceEntity
    {
        /// <summary>
        /// Gets or sets the start date.
        /// </summary>
        public DateTime StartDate { get; set; }

        /// <summary>
        /// Gets or sets the sku id.
        /// </summary>
        public long SkuId { get; set; }

        /// <summary>
        /// Gets or sets the pro price.
        /// </summary>
        public decimal? ProPrice { get; set; }

        /// <summary>
        /// Gets or sets the store price limit.
        /// </summary>
        [Column("MgrLimit")]
        public decimal StorePriceLimit { get; set; }

        /// <summary>
        /// Gets or sets the regional price limit.
        /// </summary>
        [Column("DstLimit")]
        public decimal RegionalPriceLimit { get; set; }

        /// <summary>
        /// Gets or sets the pro percent.
        /// </summary>
        public decimal ProPercent { get; set; }

        /// <summary>
        /// Gets or sets the store price percent limit.
        /// </summary>
        [Column("MgrPercent")]
        public decimal StorePricePercentLimit { get; set; }

        /// <summary>
        /// Gets or sets the regional price percent limit.
        /// </summary>
        [Column("DstPercent")]
        public decimal RegionalPricePercentLimit { get; set; }

        /// <summary>
        /// Gets or set the ProPrice StatusCode
        /// </summary>
        public string StatusCode { get; set; }

        /// <summary>
        /// Gets or sets the price mode.
        /// </summary>
        [MaxLength(1)]
        public string PriceMode { get; set; }


        /// <summary>
        /// Gets or sets the item sku.
        /// </summary>
        public virtual ItemSkuEntity ItemSku { get; set; }
    }
}