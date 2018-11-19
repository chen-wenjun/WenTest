using System.Collections.Generic;
using Mi9.Store.ViewModels.ViewModels.Enums;
using Newtonsoft.Json;

namespace Mi9.Store.ViewModels.ViewModels
{
    public class DiscrepancyViewModel
    {
        [JsonProperty("discrepancyNumber")]
        public long DiscrepancyNumber { get; set; }

        [JsonProperty("transferNumber")]
        public string TransferNumber { get; set; }

        [JsonProperty("poNumber")]
        public string PONumber { get; set; }

        [JsonProperty("vendor")]
        public string Vendor { get; set; }

        [JsonProperty("shipmentNumber")]
        public string ShipmentNumber { get; set; }

        [JsonProperty("shipmentType")]
        public ShipmentTypeViewModel ShipmentType { get; set; }

        [JsonProperty("shipmentMethod")]
        public ShipMethodViewModel ShipmentMethod { get; set; }

        [JsonProperty("sendingStore")]
        public string SendingStore { get; set; }

        [JsonProperty("receivingStore")]
        public string ReceivingStore { get; set; }

        [JsonProperty("status")]
        public DiscrepancyStatus Status { get; set; }
        
        [JsonProperty("notesAndHistory")]
        public NotesAndHistoryViewModel NotesAndHistory { get; set; }

        [JsonProperty("items")]
        public IEnumerable<DiscrepancyDetailViewModel> Items { get; set; }
    }
}
