namespace Mi9.Store.ViewModels.ViewModels
{
    public class InventoryAdjustmentTotalsViewModel
    {
        public decimal QuantityDiscrepancy { get; set; }
        public decimal QuantityDiscrepancyPercent { get; set; }
        public decimal CostDiscrepancy { get; set; }
        public decimal CostDiscrepancyPercent { get; set; }
        public decimal RetailDiscrepancy { get; set; }
        public decimal RetailDiscrepancyPercent { get; set; }
        public int Discrepancy { get; set; }
        public int RejectedItems { get; set; }

    }
}
