using System.Collections.Generic;
using Newtonsoft.Json;

namespace Mi9.Store.ViewModels.ViewModels
{
    public class PurchaseHandheldViewModel
    {
        [JsonProperty(PropertyName = "purchaseOrderNumber")]
        public string PurchaseOrderNumber { get; set; }

        [JsonProperty(PropertyName = "status")]
        public string Status { get; set; }

        [JsonProperty(PropertyName = "store")]
        public string Store { get; set; }

        [JsonProperty(PropertyName = "pallets")]
        public IEnumerable<PalletForAuditViewModel> Pallets { get; set; }
    }
}
