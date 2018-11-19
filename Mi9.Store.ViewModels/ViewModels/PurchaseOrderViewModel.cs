using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Mi9.Store.ViewModels.ViewModels
{
    public class PurchaseOrderViewModel
    {
        [JsonProperty(PropertyName = "shipmentNumbers")]
        public IEnumerable<string> ShipmentNumbers { get; set; }

        [JsonProperty(PropertyName = "purchaseOrderNumber")]
        public string PurchaseOrderNumber { get; set; }

        [JsonProperty(PropertyName = "createdDate")]
        public DateTime? CreatedDate { get; set; }

        [JsonProperty(PropertyName = "deliveryDate")]
        public DateTime? DeliveryDate { get; set; }

        [JsonProperty(PropertyName = "authorizeDate")]
        public DateTime? AuthorizeDate { get; set; }

        [JsonProperty(PropertyName = "authorized")]
        public bool Authorized { get; set; }

        [JsonProperty(PropertyName = "orderDate")]
        public DateTime? OrderDate { get; set; }

        [JsonProperty(PropertyName = "reference")]
        public string Reference { get; set; }

        [JsonProperty(PropertyName = "originalPrintedDate")]
        public DateTime? PrintedDate { get; set; }

        [JsonProperty(PropertyName = "type")]
        public string Type { get; set; }

        [JsonProperty(PropertyName = "status")]
        public string Status { get; set; }

        [JsonProperty(PropertyName = "receivedDate")]
        public DateTime? ReceivedDate { get; set; }
        
        [JsonProperty(PropertyName = "DestCode")]
        public short? DestCode { get; set; }

        [JsonProperty(PropertyName = "vendor")]
        public VendorViewModel Vendor { get; set; }

        [JsonProperty(PropertyName = "items")]
        public IEnumerable<PurchaseOrderItemViewModel> Items { get; set; }

        [JsonProperty(PropertyName = "notesAndHistory")]
        public NotesAndHistoryViewModel NotesAndHistory { get; set; }
    }
}