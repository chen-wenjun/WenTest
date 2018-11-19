using Newtonsoft.Json;

namespace Mi9.Store.ViewModels.ViewModels
{
    public class PrinterMaintenanceViewModel
    {
        [JsonProperty(PropertyName = "printerId")]
        public short Id { get; set; }

        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }

        [JsonProperty(PropertyName = "shortName")]
        public string ShortName { get; set; }

        [JsonProperty(PropertyName = "physicalPrinter")]
        public string PhysicalPrinter { get; set; }

        [JsonProperty(PropertyName = "printServer")]
        public string PrintServer { get; set; }

        [JsonProperty(PropertyName = "printerModel")]
        public string PrinterModel { get; set; }

        [JsonProperty(PropertyName = "port")]
        public int Port { get; set; }

        [JsonProperty(PropertyName = "mobile")]
        public bool Mobile { get; set; }

        [JsonProperty(PropertyName = "deleted")]
        public bool Deleted { get; set; }

        [JsonProperty(PropertyName = "canDelete")]
        public bool CanDelete { get; set; }

        [JsonProperty(PropertyName = "ip")]
        public string Ip { get; set; }

        [JsonProperty(PropertyName = "handheldid")]
        public string HandheldId { get; set; }
    }
}
