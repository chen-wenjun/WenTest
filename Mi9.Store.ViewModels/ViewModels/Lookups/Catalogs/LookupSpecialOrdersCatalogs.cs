using System.Collections.Generic;
using Mi9.Store.ViewModels.ViewModels.Enums;
using Newtonsoft.Json;

namespace Mi9.Store.ViewModels.ViewModels.Lookups.Catalogs
{
    public class LookupSpecialOrdersCatalogs : ILookupCatalogs
    {
        [JsonProperty(PropertyName = "statusCatalog")]
        public IEnumerable<SpecialOrderStatus> StatusCatalog { get; set; }
        
    }
}