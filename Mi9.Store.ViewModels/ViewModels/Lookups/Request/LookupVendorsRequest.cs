using System.Collections.Generic;

namespace Mi9.Store.ViewModels.ViewModels.Lookups.Request
{
    public class LookupVendorsRequest : LookupRequest
    {
        public string VendorId { get; set; }
        public string Name { get; set; }
        public IEnumerable<string> Active { get; set; }
        public IEnumerable<bool?> SpecificationsRequired { get; set; }
        public IEnumerable<bool?> RtvConfiguration { get; set; }
    }
}