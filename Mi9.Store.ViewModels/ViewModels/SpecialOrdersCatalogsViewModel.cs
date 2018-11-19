using System.Collections.Generic;
using Mi9.Store.ViewModels.ViewModels.Enums;
using Newtonsoft.Json;

namespace Mi9.Store.ViewModels.ViewModels
{
    public class SpecialOrdersCatalogsViewModel
    {
        [JsonProperty("specialOrdersStatuses")]
        public IEnumerable<SpecialOrderStatus> SpecialOrdersStatuses { get; set; }
        [JsonProperty("poTrackingLogTypes")]
        public IEnumerable<PoTrackingLogType> PoTrackingLogTypes { get; set; }
        [JsonProperty("purchaseOrderStatuses")]
        public IEnumerable<PurchaseOrderStatus> PurchaseOrderStatuses { get; set; }
        [JsonProperty("purchaseOrderCancelStatuses")]
        public IEnumerable<PurchaseOrderCancelStatus> PurchaseOrderCancelStatuses { get; set; }
        [JsonProperty("mdcs")]
        public IEnumerable<short> Mdcs { get; set; }
    }
}
