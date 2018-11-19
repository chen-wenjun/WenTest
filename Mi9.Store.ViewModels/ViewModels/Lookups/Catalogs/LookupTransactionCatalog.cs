using System.Collections.Generic;
using Newtonsoft.Json;

namespace Mi9.Store.ViewModels.ViewModels.Lookups.Catalogs
{
    public class LookupTransactionCatalog : ILookupCatalogs
    {
        [JsonProperty(PropertyName = "reasonsCatalog")]
        public IEnumerable<object> ReasonsCatalog { get; set; }

        [JsonProperty(PropertyName = "statusCatalog")]
        public IEnumerable<object> StatusCatalog { get; set; }

    }
}