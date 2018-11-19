using System.Collections.Generic;

namespace Mi9.Store.ViewModels.ViewModels.Lookups.Request
{
    public class LookupItemSkusRequest : LookupRequest
    {
        public string Keyword { get; set; }
        public IEnumerable<string> SkuType { get; set; }
        public IEnumerable<string> SkuStatusCode { get; set; }
        public IEnumerable<string> SkuLabelType { get; set; }
        public IEnumerable<short?> Department { get; set; }
        public IEnumerable<short?> DepartmentClass { get; set; }
        public IEnumerable<short?> DepartmentSubClass { get; set; }
        public string Description { get; set; }
        public string Vendor { get; set; }
        public string ItemNumber { get; set; }
        public IEnumerable<string> SkuUniqueItemCode { get; set; }
        public string SkuPendingPrice { get; set; }
        public string SkuPendingPromo { get; set; }
    }
}