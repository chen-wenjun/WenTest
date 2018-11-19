using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Mi9.Store.ViewModels.ViewModels
{
    public class PalletForAuditViewModel
    {
        [JsonProperty(PropertyName = "palletId")]
        public string PalletId { get; set; }

        [JsonProperty(PropertyName = "by")]
        public string AuditBy { get; set; }

        [JsonProperty(PropertyName = "storeAudit")]
        public bool StoreAudit { get; set; }

        [JsonProperty(PropertyName = "systemAudit")]
        public bool SystemAudit { get; set; }

        [JsonProperty(PropertyName = "auditStatus")]
        public string AuditStatus { get; set; }

        [JsonProperty(PropertyName = "shipmentNumber")]
        public string ShipmentNumber { get; set; }

        [JsonProperty(PropertyName = "shipmentType")]
        public string ShipmentType { get; set; }

        [JsonProperty(PropertyName = "poNumber")]
        public string DocumentNumber { get; set; }

        [JsonProperty(PropertyName = "from")]
        public string From { get; set; }

        [JsonProperty(PropertyName = "to")]
        public string To { get; set; }

        [JsonProperty(PropertyName = "printedLabelOriginalDate")]
        public DateTime? PrintedLabelOriginalDate { get; set; }

        [JsonProperty(PropertyName = "notesAndHistory")]
        public NotesAndHistoryViewModel NotesAndHistory { get; set; }
        /// <summary>
        /// Gets or sets the date last update.
        /// </summary>
        [JsonProperty(PropertyName = "dateLastUpdated")]
        public DateTime? DateLastUpdated { get; set; }

        [JsonProperty(PropertyName = "items")]
        public ICollection<PalletItemForAuditViewModel> Items { get; set; }

        [JsonProperty(PropertyName = "shipmentConfirmed")]
        public bool ShipmentConfirmed { get; set; }
    }
}
