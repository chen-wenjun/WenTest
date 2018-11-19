using System;
using System.Collections.Generic;

namespace Mi9.Store.ViewModels.ViewModels.Lookups.Request
{
    public class LookupPurchaseOrdersRequest : LookupRequest
    {
        public string PONumber { get; set; }
        public string Vendor { get; set; }
        public string PayrollId { get; set; }
        public long? ItemNumber { get; set; }
        public IEnumerable<string> PurchaseOrderType { get; set; }
        public IEnumerable<string> PurchaseOrderStatus { get; set; }
        public IEnumerable<bool?> PurchaseOrderAuthorizedStatus { get; set; }
        public IEnumerable<bool?> PurchaseOrderIsSystemGeneratedType { get; set; } 
        public IEnumerable<DateTime?> CreateDate { get; set; }
        public IEnumerable<DateTime?> OrderDate { get; set; }
        public IEnumerable<DateTime?> DeliveryDate { get; set; }
         
    }
}