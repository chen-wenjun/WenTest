using System;
using System.Collections.Generic;

namespace Mi9.Store.ViewModels.ViewModels.Lookups.Request
{
    public class LookupSpecialOrdersRequest : LookupRequest
    {
        public string PurchaseOrderNumber { get; set; }
        public string Vendor { get; set; }
        public IEnumerable<string> Status { get; set; }
        public IEnumerable<DateTime?> CreateDate { get; set; }
        public int? CustomerOrderNumber { get; set; }
        public string Customer { get; set; }
    }
}