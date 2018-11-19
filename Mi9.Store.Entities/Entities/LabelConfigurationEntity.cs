namespace Mi9.Store.Entities.Entities
{
    public class LabelConfigurationEntity
    {
        public string Code { get; set; }
        public virtual LabelTypeEntity LabelType { get; set; }

        public short PrinterId { get; set; }
        public virtual PrinterEntity Printer { get; set; }
    }
}