namespace Mi9.Store.Entities.Entities
{
    public class LabelPrintingConfigurationEntity
    {
        public byte Id { get; set; }

        public byte MaxNumberLabelPerSku { get; set; }

        public byte MaxNumberLastPrinting { get; set; }

        public short PendingPriceChangeDay { get; set; }
    }
}