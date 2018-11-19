using Newtonsoft.Json;

namespace Mi9.Store.ViewModels.ViewModels
{
    public class ReturnToVendorTypeViewModel
    {
        [JsonProperty(PropertyName = "code")]
        public byte DispCode { get; set; }

        [JsonProperty(PropertyName = "instructions")]
        public string Instructions { get; set; }

        [JsonProperty(PropertyName = "returnToVendor")]
        public bool ReturnToVendor { get; set; }

        [JsonProperty(PropertyName = "rgaNumber")]
        public string RGANumber { get; set; }

        [JsonProperty(PropertyName = "repair")]
        public bool Repair { get; set; }

        [JsonProperty(PropertyName = "buyback")]
        public bool Buyback { get; set; }

        [JsonProperty(PropertyName = "destroyinStore")]
        public bool DestroyinStore { get; set; }
    }
}