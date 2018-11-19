using System.Collections.Generic;
using Mi9.Store.Entities.Entities;
using Newtonsoft.Json;

namespace Mi9.Store.ViewModels.ViewModels
{
    public class SkusByLabelToPrintViewModel
    {
        [JsonProperty(PropertyName = "labelType")]
        public string LabelType { get; set; }

        [JsonProperty(PropertyName = "column")]
        public int Column { get; set; }

        [JsonProperty(PropertyName = "row")]
        public int Row { get; set; }

        [JsonProperty(PropertyName = "printer")]
        public PrinterEntity Printer { get; set; }

        [JsonProperty(PropertyName = "skus")]
        public List<SkuViewModel> Skus { get; set; }
    }
}
