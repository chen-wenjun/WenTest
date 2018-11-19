using System.Collections.Generic;
using Newtonsoft.Json;

namespace Mi9.Store.ViewModels.ViewModels
{
    public class SpecialOrdersResaleViewViewModel
    {
        [JsonProperty(PropertyName = "cancelledReceivedPOItems")]
        public IEnumerable<CancelledReceivedOrderItemViewModel> CancelledReceivedPOItems { get; set; }
        [JsonProperty(PropertyName = "resaleOrderItems")]
        public IEnumerable<ResaleSpecialOrderItemViewModel> ResaleOrderItems { get; set; }
    }
}
