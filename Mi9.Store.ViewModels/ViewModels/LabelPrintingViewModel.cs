using System.Collections.Generic;
using Newtonsoft.Json;

namespace Mi9.Store.ViewModels.ViewModels
{
    public class LabelPrintingViewModel
    {
        [JsonProperty(PropertyName = "labelTypes")]
        public IEnumerable<LabelTypeRelationshipViewModel> LabelType { get; set; }

        [JsonProperty(PropertyName = "skusToPrint")]
        public IEnumerable<SkuLabelPrintingViewModel> SkusToPrint { get; set; }

        [JsonProperty(PropertyName = "maxLabelPerSku")]
        public byte MaxLabelPerSku { get; set; }
    }
}
