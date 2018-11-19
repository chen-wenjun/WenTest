using System;
using Newtonsoft.Json;

namespace Mi9.Store.ViewModels.ViewModels
{
    public class LastPrintingViewModel
    {
        [JsonProperty(PropertyName = "LabelType")]
        public string LabelType { get; set; }

        [JsonProperty(PropertyName = "date")]
        public DateTime Date { get; set; }

        [JsonProperty(PropertyName = "numberSku")]
        public int NumberSku { get; set; }

        [JsonProperty(PropertyName = "user")]
        public int User { get; set; }

        [JsonProperty(PropertyName = "batchId")]
        public int BatchId { get; set; }

        [JsonProperty(PropertyName = "userName")]
        public string UserName { get; set; }

        [JsonProperty(PropertyName = "reference")]
        public string Reference { get; set; }
    }
}
