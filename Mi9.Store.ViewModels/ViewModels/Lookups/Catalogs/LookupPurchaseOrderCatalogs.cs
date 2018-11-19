using System.Collections.Generic;
using Mi9.Store.ViewModels.ViewModels.Enums;
using Newtonsoft.Json;

namespace Mi9.Store.ViewModels.ViewModels.Lookups.Catalogs
{
    public class LookupPurchaseOrderCatalogs : ILookupCatalogs
    {
        //catalogs
        [JsonProperty(PropertyName = "purchaseOrderTypeCatalog")]
        public IEnumerable<PurchaseOrderType> PurchaseOrderTypeCatalog { get; set; }
        [JsonProperty(PropertyName = "purchaseOrderStatusCatalog")]
        public IEnumerable<PurchaseOrderStatus> PurchaseOrderStatusCatalog { get; set; }
        [JsonProperty(PropertyName = "purchaseOrderAuthorizedStatusCatalog")]
        public IEnumerable<PurchaseOrderAuthorizedStatus> PurchaseOrderAuthorizedStatusCatalog { get; set; }
        [JsonProperty(PropertyName = "purchaseOrderIsSystemGeneratedTypeCatalog")]
        public IEnumerable<PurchaseOrderIsSystemGeneratedType> PurchaseOrderIsSystemGeneratedTypeCatalog { get; set; }
    }
}