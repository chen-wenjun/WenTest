using Mi9.Store.Entities.Entities;

namespace Mi9.Store.ViewModels.ViewModels
{
    public class LabelConfigurationViewModel
    {
        public string Code { get; set; }
        public virtual LabelTypeViewModel LabelTypeViewModel { get; set; }

        public short PrinterId { get; set; }
        public virtual PrinterEntity Printer { get; set; }
    }
}
