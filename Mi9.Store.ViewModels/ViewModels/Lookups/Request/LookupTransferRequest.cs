using System;
using System.Collections.Generic;

namespace Mi9.Store.ViewModels.ViewModels.Lookups.Request
{
    public class LookupTransferRequest : LookupRequest
    {
        public string TransferNumber { get; set; }
        public IEnumerable<string> TransferStatus { get; set; }
        public IEnumerable<string> TransferType { get; set; }
        public short? RequestStore { get; set; }
        public short? SourceStore { get; set; }
        public DateTime? CreatedDate { get; set; }
    }
}