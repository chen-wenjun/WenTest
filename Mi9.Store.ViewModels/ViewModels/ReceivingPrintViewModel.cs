using System.Collections.Generic;
using Mi9.Store.Entities.Entities;
using Newtonsoft.Json;

namespace Mi9.Store.ViewModels.ViewModels
{
    public class ReceivingPrintViewModel
    {
        [JsonProperty(PropertyName = "printer")]
        public PrinterEntity Printer { get; set; }

        [JsonProperty(PropertyName = "palletno")]
        public string PalletNo { get; set; }

        [JsonProperty(PropertyName = "title")]
        public string Title { get; set; }

        [JsonProperty(PropertyName = "dateinit")]
        public string DateInit { get; set; }

        [JsonProperty(PropertyName = "dateend")]
        public string DateEnd { get; set; }

        [JsonProperty(PropertyName = "createrec")]
        public string CreateRec { get; set; }

        [JsonProperty(PropertyName = "status")]
        public string Status { get; set; }

        [JsonProperty(PropertyName = "list")]
        public List<ReceivingGridPrintViewModel> List { get; set; }
    }
}
