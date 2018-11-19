using System.Collections.Generic;
using Newtonsoft.Json;
using Mi9.Store.ViewModels.ViewModels.Enums;

namespace Mi9.Store.ViewModels.ViewModels.Lookups.Catalogs
{
    public class LookupEmployeeCatalogs : ILookupCatalogs
    {
        [JsonProperty(PropertyName = "taBadgeCatalog")]
        public IEnumerable<BooleanState> HasTaBadgeCatalog { get; set; }
        
    }
}