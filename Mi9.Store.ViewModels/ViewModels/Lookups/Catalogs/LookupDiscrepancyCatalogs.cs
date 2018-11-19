using System.Collections.Generic;
using Mi9.Store.ViewModels.ViewModels.Enums;
using Newtonsoft.Json;

namespace Mi9.Store.ViewModels.ViewModels.Lookups.Catalogs
{
    public class LookupDiscrepancyCatalogs : ILookupCatalogs
    {
        //catalogs
        [JsonProperty(PropertyName = "discrepancyTypeCatalog")]
        public IEnumerable<DiscrepancyType> DiscrepancyTypeCatalog { get; set; }
        [JsonProperty(PropertyName = "shipmentTypeCatalog")]
        public IEnumerable<ShipmentType> ShipmentTypeCatalog { get; set; }
        [JsonProperty(PropertyName = "shipmentMethodCatalog")]
        public IEnumerable<ShipmentMethod> ShipmentMethodCatalog { get; set; }
        [JsonProperty(PropertyName = "sendingLocationCatalog")]
        public IEnumerable<StoreObj> SendingLocationCatalog { get; set; }
        [JsonProperty(PropertyName = "destinationLocationCatalog")]
        public IEnumerable<StoreObj> DestinationLocationCatalog { get; set; }
        [JsonProperty(PropertyName = "discrepancyStatusCatalog")]
        public IEnumerable<DiscrepancyStatus> DiscrepancyStatusCatalog { get; set; }
        [JsonProperty(PropertyName = "discrepancyActionCatalog")]
        public IEnumerable<DiscrepancyAction> DiscrepancyActionCatalog { get; set; }
    }
}