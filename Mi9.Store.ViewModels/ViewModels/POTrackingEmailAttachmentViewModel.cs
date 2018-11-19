using Newtonsoft.Json;

namespace Mi9.Store.ViewModels.ViewModels
{
    public class PoTrackingEmailAttachmentViewModel
    {
        [JsonProperty("id")]
        public long Id { get; set; }
        [JsonProperty("fileName")]
        public string FileName { get; set; }
    }
}
