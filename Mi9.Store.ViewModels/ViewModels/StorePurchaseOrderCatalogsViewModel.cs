using System.Collections.Generic;
using Mi9.Store.ViewModels.ViewModels.Enums;
using Newtonsoft.Json;

namespace Mi9.Store.ViewModels.ViewModels
{
    public class StorePurchaseOrderCatalogsViewModel
    {
        [JsonProperty("purchaseOrderStatuses")]
        public IEnumerable<PurchaseOrderStatus> PurchaseOrderStatuses { get; set; }
        [JsonProperty("purchaseOrderTypes")]
        public IEnumerable<PurchaseOrderType> PurchaseOrderTypes { get; set; }
    }
}
