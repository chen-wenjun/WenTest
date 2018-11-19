using System.Collections.Generic;
using Newtonsoft.Json;

namespace Mi9.Store.ViewModels.ViewModels
{
    public class PoTrackingEntryViewModel
    {
        [JsonProperty("poNumber")]
        public string PoNumber { get; set; }
        [JsonProperty("orderNumber")]
        public int? OrderNumber { get; set; }
        [JsonProperty("notes")]
        public string Notes { get; set; }
        [JsonProperty("cancelStatus")]
        public PoTrackingCancelStatusViewModel CancelStatus { get; set; }
        [JsonProperty("states")]
        public IEnumerable<PoTrackingDetailViewModel> States { get; set; }
        [JsonProperty("logs")]
        public IEnumerable<PoTrackingLogViewModel> Logs { get; set; }
        [JsonProperty("attachments")]
        public IEnumerable<PoTrackingEmailAttachmentViewModel> Attachments { get; set; }
        [JsonProperty("newAttachments")]
        public IEnumerable<string> NewAttachments { get; set; }


        //vendorInfo
        [JsonProperty("vendorInfo")]
        public PoTrackingEntryVendorInfoViewModel VendorInfo { get; set; }

        //customerInfo
        [JsonProperty("customerInfo")]
        public PoTrackingEntryCustomerInfoViewModel CustomerInfo { get; set; }

        //destinationStore
        [JsonProperty("destinationStore")]
        public short? DestinationStore { get; set; }

        //purchaseOrder info
        [JsonProperty("purchaseOrderStatusCode")]
        public string PurchaseOrderStatusCode { get; set; }
    }
}
