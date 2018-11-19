using System.Collections.Generic;
using Newtonsoft.Json;

namespace Mi9.Store.ViewModels.ViewModels
{
    public class TransferHandheldViewModel
    {
        [JsonProperty(PropertyName = "transferNumber")]
        public string TransferNumber { get; set; }

        [JsonProperty(PropertyName = "status")]
        public string Status { get; set; }

        [JsonProperty(PropertyName = "requestStore")]
        public string RequestStore { get; set; }

        [JsonProperty(PropertyName = "sourceStore")]
        public string SourceStore { get; set; }

        [JsonProperty(PropertyName = "pallets")]
        public IEnumerable<PalletForAuditViewModel> Pallets { get; set; }
    }
}
