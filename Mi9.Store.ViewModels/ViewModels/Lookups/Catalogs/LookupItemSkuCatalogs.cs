using System.Collections.Generic;
using Mi9.Store.ViewModels.ViewModels.Enums;
using Newtonsoft.Json;

namespace Mi9.Store.ViewModels.ViewModels.Lookups.Catalogs
{
    public class LookupItemSkuCatalogs : ILookupCatalogs
    {
        //catalogs
        [JsonProperty(PropertyName = "skuUniqueItemCodeCatalog")]
        public IEnumerable<SkuUniqueItemCode> SkuUniqueItemCodeCatalog { get; set; }
        [JsonProperty(PropertyName = "skuTypeCatalog")]
        public IEnumerable<SkuType> SkuTypeCatalog { get; set; }
        [JsonProperty(PropertyName = "skuStatusCodeCatalog")]
        public IEnumerable<SkuStatusCode> SkuStatusCodeCatalog { get; set; }
        [JsonProperty(PropertyName = "skuLabelTypeCatalog")]
        public IEnumerable<SkuItemType> SkuLabelTypeCatalog { get; set; }
        [JsonProperty(PropertyName = "departmentCatalog")]
        public IEnumerable<DepartmentViewModel> DepartmentCatalog { get; set; }
    }
}