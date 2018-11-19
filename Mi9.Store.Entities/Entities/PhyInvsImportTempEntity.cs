namespace Mi9.Store.Entities.Entities
{
    public class PhyInvsImportTempEntity
    {
        public int Id { get; set; }
        public int Section { get; set; }
        public int Area { get; set; }
        public string Zone { get; set; }
        public string Bay { get; set; }
        public int Department { get; set; }
        
        public long Sku { get; set; }
        
        public long? AlternateSku { get; set; }
        public int Breakdown { get; set; }
        public decimal RetailPrice { get; set; }
        public decimal AverageCost { get; set; }
        public int OnHandQuantity { get; set; }
        public string Status { get; set; }
        public string VelocityCode { get; set; }
    }
}

