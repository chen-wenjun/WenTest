namespace Mi9.Store.Entities.Entities
{
    public class PrintingBatchDetailEntity
    {
        public int BatchHeaderId { get; set; }

        public long Sku { get; set; }

        public byte NumberOfLabels { get; set; }

        public int Id { get; set; }

        public bool HasPrice { get; set; }

        public virtual PrintingBatchHeaderEntity BatchHeader { get; set; }
    }
}
