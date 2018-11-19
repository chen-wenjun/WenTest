

using System;
using System.Collections.Generic;
using Mi9.Store.ViewModels.Converters;
using Newtonsoft.Json;

namespace Mi9.Store.ViewModels.ViewModels
{
    public class TransferSuggestionViewModel
    {
        [JsonProperty(PropertyName = "id")]
        public string TransferNumber { get; set; }

        [JsonProperty(PropertyName = "status")]
        public TransferStatusViewModel Status { get; set; }

        [JsonProperty(PropertyName = "shipMethod")]
        public ShipMethodViewModel ShipMethod { get; set; }

        [JsonProperty(PropertyName = "shippedDate")]
        [JsonConverter(typeof(IsoUtcDateTimeConverter))]
        public DateTime? ReqShipDate { get; set; }

        [JsonProperty(PropertyName = "reason")]
        public ReasonViewModel Reason { get; set; }

        [JsonProperty(PropertyName = "note")]
        public string Note { get; set; }

        [JsonProperty(PropertyName = "amended")]
        [JsonConverter(typeof(IsoUtcDateTimeConverter))]
        public DateTime? DateLastUpd { get; set; }

        [JsonProperty(PropertyName = "itemArr")]
        public ICollection<InventoryInquiryItemViewModel> Items { get; set; }

        [JsonProperty(PropertyName = "created")]
        [JsonConverter(typeof(IsoUtcDateTimeConverter))]
        public DateTime? DateCreated { get; set; }

        [JsonProperty(PropertyName = "approved")]
        [JsonConverter(typeof(IsoUtcDateTimeConverter))]
        public DateTime? DateApproved { get; set; }

        [JsonProperty(PropertyName = "transfers")]
        public virtual ICollection<TransferUdtViewModel> Transfers { get; set; }

        [JsonProperty(PropertyName = "historyAndNotes")]
        public  NotesAndHistoryViewModel HistoryAndNotes{ get; set; } 

    }
}
