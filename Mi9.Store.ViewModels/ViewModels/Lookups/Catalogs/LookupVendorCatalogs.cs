using System.Collections.Generic;
using Newtonsoft.Json;
using Mi9.Store.ViewModels.ViewModels.Enums;

namespace Mi9.Store.ViewModels.ViewModels.Lookups.Catalogs
{
    public class LookupVendorCatalogs : ILookupCatalogs
    {
        [JsonProperty(PropertyName = "rtvConfigurationCatalog")]
        public IEnumerable<BooleanState> RtvConfigurationCatalog { get; set; }
        [JsonProperty(PropertyName = "activeCatalog")]
        public IEnumerable<VendorStatus> ActiveCatalog { get; set; }
        [JsonProperty(PropertyName = "specificationsRequiredCatalog")]
        public IEnumerable<BooleanState> SpecificationsRequiredCatalog { get; set; }
    }
}