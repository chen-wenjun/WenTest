using System;
using System.Collections.Generic;

namespace Mi9.Store.ViewModels.ViewModels.Lookups.Request
{
    public class LookupTransactionsRequest : LookupRequest
    {
        public long? TransactionNumber { get; set; }
        public string ItemNumber { get; set; }
        public IEnumerable<byte?> Reasons { get; set; }
        public IEnumerable<byte?> Status { get; set; }
        public DateTime? From { get; set; }
        public DateTime? To { get; set; }
        public int? SalesAssociate { get; set; }
    }
}