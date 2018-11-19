using System;
using Newtonsoft.Json;

namespace Mi9.Store.ViewModels.ViewModels
{
    public class NotesAndHistoryViewModel
    {
        [JsonProperty(PropertyName = "createdBy")]
        public string CreatedBy { get; set; }
        [JsonProperty(PropertyName = "createdOn")]
        public DateTime? CreatedOn { get; set; }
        
        [JsonProperty(PropertyName = "updatedBy")]
        public string UpdatedBy { get; set; }
        [JsonProperty(PropertyName = "updatedOn")]
        public DateTime? UpdatedOn { get; set; }
        
        [JsonProperty(PropertyName = "confirmedBy")]
        public string ConfirmedBy { get; set; }
        [JsonProperty(PropertyName = "confirmedOn")]
        public DateTime? ConfirmedOn { get; set; }

        [JsonProperty(PropertyName = "approvedBy")]
        public string ApprovedBy { get; set; }
        [JsonProperty(PropertyName = "approvedOn")]
        public DateTime? ApprovedOn { get; set; }

        [JsonProperty(PropertyName = "shippedBy")]
        public string ShippedBy { get; set; }
        [JsonProperty(PropertyName = "shippedOn")]
        public DateTime? ShippedOn { get; set; }

        [JsonProperty(PropertyName = "voidedBy")]
        public string VoidedBy { get; set; }
        [JsonProperty(PropertyName = "voidedOn")]
        public DateTime? VoidedOn { get; set; }

        [JsonProperty(PropertyName = "closedBy")]
        public string ClosedBy { get; set; }
        [JsonProperty(PropertyName = "closedOn")]
        public DateTime? ClosedOn { get; set; }
        
        [JsonProperty(PropertyName = "notes")]
        public string Notes { get; set; }
    }
}
