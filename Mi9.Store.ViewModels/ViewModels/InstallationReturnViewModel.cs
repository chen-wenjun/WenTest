using System;
using Mi9.Store.ViewModels.Converters;
using Newtonsoft.Json;

namespace Mi9.Store.ViewModels.ViewModels
{
    public class InstallationReturnViewModel
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("orderId")]
        public int OrderId { get; set; }

        [JsonProperty("customer")]
        public CustomerViewModel Customer { get; set; }

        [JsonProperty("installType")]
        public string InstallType { get; set; }

        [JsonProperty("status")]
        public InstallationRequestStatusViewModel Status { get; set; }

        [JsonProperty("createdDate")]
        [JsonConverter(typeof(IsoUtcDateTimeConverter))]
        public DateTime? CreatedDate { get; set; }

        [JsonProperty("total")]
        public decimal Total { get; set; }

        [JsonProperty("installationCost")]
        public decimal InstallationCost { get; set; }

        [JsonProperty("installationRequest")]
        public InstallationRequestViewModel OriginalRequest { get; set; }
    }
}