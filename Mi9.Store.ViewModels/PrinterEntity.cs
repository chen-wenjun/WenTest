using System.Collections.Generic;

namespace Mi9.Store.Entities.Entities
{
    public class PrinterEntity
    {
        public short Id { get; set; }

        public string PhysicalPrinter { get; set; }

        public string Description { get; set; }

        public string ShortName { get; set; }
        
        public string PrintServer { get; set; }

        public string PrinterModel { get; set; }

        public string Ip { get; set; }

        public int Port { get; set; }

        public bool Mobile { get; set; }

        //public virtual ICollection<LabelConfigurationEntity> LabelConfigurationItems { get; set; }

        // Added for the link and unlink
        public string HandheldId { get; set; }
    }
}