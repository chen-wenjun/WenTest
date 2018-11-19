using System.Collections.Generic;
using Newtonsoft.Json;

namespace Mi9.Store.ViewModels.ViewModels
{
    public class SpecialOrdersResaleItemLinkViewModel
    {
        [JsonProperty(PropertyName = "cancelledReceivedPOItems")]
        public IEnumerable<CancelledReceivedOrderItemViewModel> CancelledReceivedPoItems { get; set; }
        [JsonProperty(PropertyName = "resaleOrderItem")]
        public ResaleSpecialOrderItemViewModel ResaleOrderItem { get; set; }
    }
}
