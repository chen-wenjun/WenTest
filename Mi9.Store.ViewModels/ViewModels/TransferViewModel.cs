using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Mi9.Store.ViewModels.ViewModels
{
    public class TransferViewModel
    {
        [JsonProperty(PropertyName = "transferNumber")]
        public string TransferNumber { get; set; }

        [JsonProperty(PropertyName = "status")]
        public string Status { get; set; }

        [JsonProperty(PropertyName = "requestStore")]
        public StoreViewModel RequestStore { get; set; }

        [JsonProperty(PropertyName = "sourceStore")]
        public StoreViewModel SourceStore { get; set; }

        [JsonProperty(PropertyName = "toBeShippingOn")]
        public DateTime? ToBeShippingOn { get; set; }

        [JsonProperty(PropertyName = "shipmentRef")]
        public string ShipmentRef { get; set; }

        [JsonProperty(PropertyName = "driverRef")]
        public string DriverRef { get; set; }

        [JsonProperty(PropertyName = "truckNumber")]
        public string TruckNumber { get; set; }

        [JsonProperty(PropertyName = "reason")]
        public ReasonCodeViewModel Reason { get; set; }

        [JsonProperty(PropertyName = "shipMethod")]
        public ShipMethodViewModel ShipMethod { get; set; }

        [JsonProperty(PropertyName = "transferItemsSuggested")]
        public IEnumerable<TransferItemSuggestedViewModel> TransferItemsSuggested { get; set; }

        [JsonProperty(PropertyName = "historyAndNotes")]
        public NotesAndHistoryViewModel HistoryAndNotes { get; set; }

        [JsonProperty(PropertyName = "origSuggestionNumber")]
        public string OrigSuggestionNumber { get; set; }

        [JsonProperty(PropertyName = "hOInitiated")]
        public bool HOInitiated { get; set; }

        [JsonProperty(PropertyName = "transferSummary")]
        public IEnumerable<TransferSummaryViewModel> TransferSummary { get; set; }
    }
}
