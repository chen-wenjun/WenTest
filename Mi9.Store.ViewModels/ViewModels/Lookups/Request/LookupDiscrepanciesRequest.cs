using System;
using System.Collections.Generic;

namespace Mi9.Store.ViewModels.ViewModels.Lookups.Request
{
    public class LookupDiscrepanciesRequest : LookupRequest
    {
        public IEnumerable<string> DiscrepancyType { get; set; }
        public IEnumerable<string> ShipmentType { get; set; }
        public IEnumerable<string> ShipmentMethod { get; set; }
        public IEnumerable<short?> SendingLocation { get; set; }
        public IEnumerable<string> DestinationLocation { get; set; }
        public string Vendor { get; set; }
        public string PONumber { get; set; }
        public string TransferNumber { get; set; }
        public IEnumerable<string> DiscrepancyStatus { get; set; }
        public IEnumerable<int?> DiscrepancyAction { get; set; }
        public string CreatedUserPayrollId { get; set; }
        public string ClosedUserPayrollId { get; set; }
        public IEnumerable<DateTime?> CreatedDate { get; set; }
        public IEnumerable<DateTime?> ClosedDate { get; set; }
    }
}