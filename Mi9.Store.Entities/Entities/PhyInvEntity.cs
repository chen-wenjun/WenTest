using System;
namespace Mi9.Store.Entities.Entities
{
    public class PhyInvEntity
    {
        public int Id { get; set; }
        public DateTime InventoryDate { get; set; }
        public DateTime InventoryLibDate { get; set; }
        public DateTime? SnapShotDate { get; set; }
        public DateTime? CountDate { get; set; }
        public DateTime? InitialAdjustmentDate { get; set; }
        public DateTime? InitialAdjustmentBusinessDate { get; set; }
        public DateTime? PostPhyInvDate { get; set; }
        public decimal? QtyDiscrepancy { get; set; }
        public decimal? QtyDiscrepancyPer { get; set; }
        public decimal? CostDiscrepancy { get; set; }
        public decimal? CostDiscrepancyPer { get; set; }
        public decimal? RetailDiscrepancy { get; set; }
        public decimal? RetailDiscrepancyPer { get; set; }
        public int? RejectItems { get; set; }
        public int? Discrepancy { get; set; }
        public string Status { get; set; }
    }
}
