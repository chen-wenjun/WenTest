using System.Collections.Generic;
using Mi9.Store.ViewModels.ViewModels.Enums;
using Newtonsoft.Json;

namespace Mi9.Store.ViewModels.ViewModels.Lookups.Catalogs
{
    public class LookupTransferCatalogs : ILookupCatalogs
    {
        [JsonProperty(PropertyName = "transferStatusCatalog")]
        public IEnumerable<TransferStatus> TransferStatusCatalog { get; set; }
        [JsonProperty(PropertyName = "transferTypeCatalog")]
        public IEnumerable<TransferType> TransferTypeCatalog { get; set; }
    }
}