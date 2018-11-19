
using Mi9.Store.ViewModels.Converters;

namespace Mi9.Store.ViewModels.ViewModels
{
    using System;
    using Newtonsoft.Json;

    public class InstallationAlertViewModel
    {
        [JsonProperty("installationRequestId")]
        public int RequestId { get; set; }

        [JsonProperty("autoSequence")]
        public int AutoSequence { get; set; }

        [JsonProperty("installer")]
        public InstallerView Installer { get; set; }

        [JsonProperty("id")]
        public int AlertId { get; set; }

        [JsonProperty("createdDate")]
        [JsonConverter(typeof(IsoUtcDateTimeConverter))]
        public DateTime? CreateDate { get; set; }

        [JsonProperty("type")]
        public InstallationAlertTypeViewModel AlertType { get; set; }

        [JsonProperty("statusCode")]
        public string StatusCode { get; set; }

        [JsonProperty("escalationLevel")]
        public byte EscalationLevel { get; set; }

        [JsonProperty("orderId")]
        public int OrderNo { get; set; }

        public class InstallerView
        {
            [JsonProperty("id")]
            public int Id { get; set; }

            [JsonProperty("name")]
            public string Name { get; set; }
        }
    }
}