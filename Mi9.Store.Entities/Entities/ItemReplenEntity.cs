using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Mi9.Store.Entities.Entities
{
    /// <summary>
    /// The item replen entity.
    /// </summary>
    public class ItemReplenEntity
    {
        public long Sku { get; set; }
        public long AltRelatSku { get; set; }

        /// <summary>
        /// Gets or sets the quantity on hand.
        /// </summary>
        public decimal? QuantityOnHand { get; set; }

        /// <summary>
        /// Gets or sets the quantity reserved.
        /// </summary>
        public decimal? QuantityReserved { get; set; }

        /// <summary>
        /// Gets or sets the quatity on hold.
        /// </summary>
        public decimal? QuatityOnHold { get; set; }

        /// <summary>
        ///  Gets or sets the first quatity on hold.
        /// </summary>
        public decimal? PreCountQty { get; set; }

        /// <summary>
        /// Gets or sets the quantity on order.
        /// </summary>
        public decimal? QuantityOnOrder { get; set; }

        /// <summary>
        /// Gets or sets the season id.
        /// </summary>
        public byte? SeasonId { get; set; }

        /// <summary>
        /// Gets or sets the unit cube.
        /// </summary>
        public decimal UnitCube { get; set; }

        /// <summary>
        /// Gets or sets the quantity on x dock.
        /// </summary>
        public int QuantityOnXDock { get; set; }

        /// <summary>
        /// Gets or sets the quantity in transit.
        /// </summary>
        public decimal QuantityInTransit { get; set; }

        /// <summary>
        /// Gets or sets the display qty.
        /// </summary>
        public decimal DisplayQty { get; set; }

        /// <summary>
        /// Gets or sets the week sales 1.
        /// </summary>
        public decimal WeekSales1 { get; set; }

        /// <summary>
        /// Gets or sets the week sales 2.
        /// </summary>
        public decimal WeekSales2 { get; set; }

        /// <summary>
        /// Gets or sets the week sales 3.
        /// </summary>
        public decimal WeekSales3 { get; set; }

        /// <summary>
        /// Gets or sets the week sales 4.
        /// </summary>
        public decimal WeekSales4 { get; set; }

        /// <summary>
        /// Gets or sets the week sales 5.
        /// </summary>
        public decimal WeekSales5 { get; set; }

        /// <summary>
        /// Gets or sets the week sales 6.
        /// </summary>
        public decimal WeekSales6 { get; set; }

        /// <summary>
        /// Gets or sets the week sales 7.
        /// </summary>
        public decimal WeekSales7 { get; set; }

        /// <summary>
        /// Gets or sets the week sales 8.
        /// </summary>
        public decimal WeekSales8 { get; set; }

        /// <summary>
        /// Gets or sets the week sales 9.
        /// </summary>
        public decimal WeekSales9 { get; set; }

        /// <summary>
        /// Gets or sets the week sales 10.
        /// </summary>
        public decimal WeekSales10 { get; set; }

        /// <summary>
        /// Gets or sets the week sales 11.
        /// </summary>
        public decimal WeekSales11 { get; set; }

        /// <summary>
        /// Gets or sets the week sales 12.
        /// </summary>
        public decimal WeekSales12 { get; set; }

        /// <summary>
        /// Gets or sets the week sales 13.
        /// </summary>
        public decimal WeekSales13 { get; set; }

        /// <summary>
        /// Gets or sets the week sales 14.
        /// </summary>
        public decimal WeekSales14 { get; set; }

        /// <summary>
        /// Gets or sets the week sales 15.
        /// </summary>
        public decimal WeekSales15 { get; set; }

        /// <summary>
        /// Gets or sets the week sales 16.
        /// </summary>
        public decimal WeekSales16 { get; set; }

        /// <summary>
        /// Gets or sets the english description.
        /// </summary>
        public string EngDesc { get; set; }

        /// <summary>
        /// Gets or sets the spanish description.
        /// </summary>
        public string SpanishDesc { get; set; }

        /// <summary>
        /// Gets or sets the velocity code.
        /// </summary>
        [StringLength(1)]
        public string VelocityCode { get; set; }

        /// <summary>
        /// Gets or sets the user lookup.
        /// </summary>
        [StringLength(15)]
        public string UserLookup { get; set; } 

        /// <summary>
        /// Gets or sets the store model stock.
        /// </summary>
        public int StorModelStk { get; set; }

       
        /// <summary>
        /// Gets or sets the item sku.
        /// </summary>
        public virtual ItemSkuEntity ItemSku { get; set; }

        /// <summary>
        /// Gets or sets the season.
        /// </summary>
        public virtual SeasonEntity Season { get; set; }

        public ICollection<PackDownEntity> PackDowns { get; set; }

        public byte NumberLabels { get; set; }

        public string LabelType { get; set; }

        public string LabelFeature3 { get; set; }
        public string LabelFeature4 { get; set; }
        public string LabelFeature5 { get; set; }

        public string POplacement { get; set; }
        public DateTime? ReviewDate { get; set; }

        public decimal LastCost { get; set; }
    }
}