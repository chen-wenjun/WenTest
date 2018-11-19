using System;

namespace Mi9.Store.ViewModels.ViewModels
{
    public class LabelToPrintViewModel
    {
        public DateTime Date { get; set; }
        public decimal PromoPrice { get; set; }
        public decimal RetailPrice { get; set; }
        public string Uom { get; set; }
        public string Description { get; set; }
        public string Department { get; set; }
        public long Sku { get; set; }
        public string Upc { get; set; }
        public string EnergyConsumption { get; set; }
        public string StandbyEnergyConsumption { get; set; }
        public string ProductEnergybyUnit { get; set; }
        public int DealQty { get; set; }
        public decimal DealPrice { get; set; }
        public int PromoDealQty { get; set; }
        public decimal PromoDealPrice { get; set; }
        public decimal TotalSaving { get; set; }
        public decimal UnitSavings { get; set; }

    }
}
