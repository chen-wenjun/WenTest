using System.ComponentModel.DataAnnotations.Schema;

namespace Mi9.Store.Entities.Entities
{
    /// <summary>
    /// The pro discount entity.
    /// </summary>
    public class ProDiscountEntity
    {
        /// <summary>
        /// Gets or sets the margin.
        /// </summary>
        public decimal Margin { get; set; }

        /// <summary>
        /// Gets or sets the pro percent.
        /// </summary>
        public decimal? ProPercent { get; set; }

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
    }
}