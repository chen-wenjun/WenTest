namespace Mi9.Store.Entities.Entities
{
    public class TaxEntity
    {
        public string TaxCode { get; set; }

        public string TaxName { get; set; }

        public bool IsTaxIncluded { get; set; }

        public decimal? TaxRate { get; set; }
    }
}
