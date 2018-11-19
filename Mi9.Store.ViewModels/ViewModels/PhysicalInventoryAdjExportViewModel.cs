namespace Mi9.Store.ViewModels.ViewModels
{
    public class PhysicalInventoryAdjExportViewModel
    {
            public long Sku { get; set; } 
            public string PrimaryUpc { get; set; }
            public string SkuDescription { get; set; }
            public decimal UnitCost { get; set; }
            public short DeptNo { get; set; }
            public decimal OnhandQty { get; set; }
            public string StatusCode { get; set; }
            public  string AbcCode { get; set; }
            public decimal Preciva { get; set; }
            public long AltRelatSku { get; set; }
    }
}
