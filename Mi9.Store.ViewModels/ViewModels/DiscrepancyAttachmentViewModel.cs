using System;
using Newtonsoft.Json;

namespace Mi9.Store.ViewModels.ViewModels
{
    public class DiscrepancyAttachmentViewModel
    {
        [JsonProperty("discrepancyDetailId")]
        public long DiscrepancyDetailId { get; set; }
        [JsonProperty("url")]
        public string Url { get; set; }
        [JsonProperty("createdOn")]
        public DateTime CreatedOn { get; set; }
        [JsonProperty("createdBy")]
        public string CreatedBy { get; set; }
    }
}
