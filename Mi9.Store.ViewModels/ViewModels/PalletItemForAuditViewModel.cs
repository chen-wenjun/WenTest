using System.Collections.Generic;
using Newtonsoft.Json;

namespace Mi9.Store.ViewModels.ViewModels
{
    public class PalletItemForAuditViewModel
    {
        [JsonProperty(PropertyName = "orderQty")]
        public decimal OrderQty { get; set; }

        [JsonProperty(PropertyName = "receivedQty")]
        public decimal ReceivedQty { get; set; }

        [JsonProperty(PropertyName = "damagedQty")]
        public decimal DamagedQty { get; set; }

        [JsonProperty(PropertyName = "sku")]
        public long SKU { get; set; }

        [JsonProperty(PropertyName = "upc")]
        public string UPC { get; set;  }

        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }

        [JsonProperty(PropertyName = "vendor")]
        public string Vendor { get; set; }

        [JsonProperty(PropertyName = "vendorPack")]
        public short VendorPack { get; set; }

        [JsonProperty(PropertyName = "vendorPackInfo")]
        public VendorPackInfoViewModel VendorPackInfo { get; set; }

        [JsonProperty(PropertyName = "department")]
        public string Department { get; set; }

        [JsonProperty(PropertyName = "class")]
        public short? Class { get; set; }

        [JsonProperty(PropertyName = "subclass")]
        public short? Subclass { get; set; }

        [JsonProperty(PropertyName = "status")]
        public string Status { get; set; }

        //more fields to print label

        [JsonProperty(PropertyName = "velocityCode")]
        public string VelocityCode { get; set; }

        [JsonProperty(PropertyName = "remarks")]
        public string Remarks { get; set; }

        [JsonProperty(PropertyName = "home")]
        public IEnumerable<string> Home { get; set; }

        [JsonProperty(PropertyName = "over")]
        public IEnumerable<string> Over { get; set; }

        public int PurchaseOrderSeqNumber { get; set; }
    }
}