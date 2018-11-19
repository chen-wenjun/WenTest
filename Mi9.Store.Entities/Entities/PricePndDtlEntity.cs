namespace Mi9.Store.Entities.Entities
{
    public class PricePndDtlEntity
    {
        public long Sku { get; set; }
        public int BatchNumber { get; set; }
        public short DeptNo { get; set; }
        public short ClassNo { get; set; }
        public decimal NewPrice { get; set; }
        public short SequenceNo { get; set; }
        public virtual PricePndHdrEntity PricePndHeader { get; set; }
    }
}
