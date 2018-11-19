using System.Collections.Generic;
using Newtonsoft.Json;

namespace Mi9.Store.ViewModels.ViewModels
{
    public class PoTrackingEmailViewModel
    {
        [JsonProperty("poNumber")]
        public string PoNumber { get; set; }
        [JsonProperty("subject")]
        public string Subject { get; set; }
        [JsonProperty("to")]
        public string To { get; set; }
        [JsonProperty("cc")]
        public string Cc { get; set; }
        [JsonProperty("attachments")]
        public IEnumerable<PoTrackingEmailAttachmentViewModel> Attachments { get; set; }
        [JsonProperty("message")]
        public string Message { get; set; }
    }
}
