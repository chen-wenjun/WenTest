using System;
using Newtonsoft.Json;

namespace Mi9.Store.ViewModels.ViewModels
{
    public class PhysicalInventoryViewModel
    {
        /// <summary>
        /// Gets or sets the InventoryEntity Id.
        /// </summary>
        [JsonProperty(PropertyName = "id")]
        public int Id { get; set; }

        /// <summary>
        /// Gets or sets the InventoryEntity Date.
        /// </summary>
        [JsonProperty(PropertyName = "inventoryDate")]
        public DateTime InventoryDate { get; set; }

        /// <summary>
        /// Gets or sets the InventoryEntity Lib Date.
        /// </summary>
        [JsonProperty(PropertyName = "inventoryLibDate")]
        public DateTime InventoryLibDate { get; set; }

        /// <summary>
        /// Gets or sets the InventoryEntity Lib Date.
        /// </summary>
        [JsonProperty(PropertyName = "snapShotDate")]
        public DateTime? SnapShotDate { get; set; }

        /// <summary>
        /// Gets or sets the Count Date.
        /// </summary>
        [JsonProperty(PropertyName = "countDate")]
        public DateTime? CountDate { get; set; }

        /// <summary>
        /// Gets or sets the Count Date.
        /// </summary>
        [JsonProperty(PropertyName = "count")]
        public int Count { get; set; }

        /// <summary>
        /// Gets or sets the Initial Adjustment Date.
        /// </summary>
        [JsonProperty(PropertyName = "initialAdjustmentDate")]
        public DateTime? InitialAdjustmentDate { get; set; }


        /// <summary>
        /// Gets or sets the Initial Adjustment Business Date.
        /// </summary>
        [JsonProperty(PropertyName = "initialAdjustmentBusinessDate")]
        public DateTime? InitialAdjustmentBusinessDate { get; set; }

        /// <summary>
        /// Gets or sets the Post Physical InventoryDate.
        /// </summary>
        [JsonProperty(PropertyName = "postPhyInvDate")]
        public DateTime? PostPhyInvDate { get; set; }

        /// <summary>
        /// Gets or sets the Quantity Discrepancy.
        /// </summary>
        [JsonProperty(PropertyName = "quantityDiscrepancy")]
        public decimal? QtyDiscrepancy { get; set; }

        /// <summary>
        /// Gets or sets the Quantity DiscrepancyPercent.
        /// </summary>
        [JsonProperty(PropertyName = "quantityDiscrepancyPercent")]
        public decimal? QtyDiscrepancyPer { get; set; }

        /// <summary>
        /// Gets or sets the Cost Discrepancy.
        /// </summary>
        [JsonProperty(PropertyName = "costDiscrepancy")]
        public decimal? CostDiscrepancy { get; set; }

        /// <summary>
        /// Gets or sets the Cost Discrepancy Percent.
        /// </summary>
        [JsonProperty(PropertyName = "costDiscrepancyPercent")]
        public decimal? CostDiscrepancyPer { get; set; }

        /// <summary>
        /// Gets or sets the Retail Discrepancy.
        /// </summary>
        [JsonProperty(PropertyName = "retailDiscrepancy")]
        public decimal? RetailDiscrepancy { get; set; }

        /// <summary>
        /// Gets or sets the Retail Discrepancy Percent.
        /// </summary>
        [JsonProperty(PropertyName = "retailDiscrepancyPercent")]
        public decimal? RetailDiscrepancyPer { get; set; }

        /// <summary>
        /// Gets or sets the Rejected Items Count.
        /// </summary>
        [JsonProperty(PropertyName = "rejectItems")]
        public int? RejectItems { get; set; }

        /// <summary>
        /// Gets or sets the Discrepancy.
        /// </summary>
        [JsonProperty(PropertyName = "discrepancy")]
        public int? Discrepancy { get; set; }

        /// <summary>
        /// Gets or sets the Status.
        /// </summary>
        [JsonProperty(PropertyName = "status")]
        public string Status { get; set; }
    }
}
