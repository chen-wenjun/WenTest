using Newtonsoft.Json;

namespace Mi9.Store.ViewModels.ViewModels
{
    public class AuditDialogItemViewModel
    {
        [JsonProperty(PropertyName = "shipmentNumber")]
        public string ShipmentNumber { get; set; }

        [JsonProperty(PropertyName = "palletId")]
        public string PalletId { get; set; }

        [JsonProperty(PropertyName = "by")]
        public string By { get; set; }

        [JsonProperty(PropertyName = "status")]
        public string Status { get; set; }

        [JsonProperty(PropertyName = "selected")]
        public bool Selected { get; set; }
    }
}