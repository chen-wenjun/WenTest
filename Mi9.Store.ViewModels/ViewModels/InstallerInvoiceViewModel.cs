using System;
using Mi9.Store.ViewModels.Converters;
using Newtonsoft.Json;

namespace Mi9.Store.ViewModels.ViewModels
{
    public class InstallerInvoiceViewModel
    {
        [JsonProperty("number")]
        public string InvoiceId { get; set; }

        [JsonProperty("installerId")]
        public int InstallerId { get; set; }

        [JsonProperty("date")]
        public DateTime? InvoiceDate { get; set; }

        [JsonProperty("createdDate")]
        [JsonConverter(typeof(IsoUtcDateTimeConverter))]
        public DateTime? CreatedDate { get; set; }

        [JsonProperty("services")]
        public decimal TotalInstaller { get; set; } // todo: verify with UI

        [JsonProperty("tax")]
        public decimal Tax { get; set; }

        [JsonProperty("total")]
        public decimal Total { get; set; }

        [JsonProperty("autorized")]
        public bool IsAuthorized { get; set; }

        [JsonProperty("requests")]
        public int[] RequestIds { get; set; }

        [JsonProperty("installer")]
        public InstallerViewModel Installer { get; set; }

        // todo: Confirm Mapping Invoice Total.   Should this be the sum of InstInv.TotInstaller + Instinv.TaxAmount?
    }
}