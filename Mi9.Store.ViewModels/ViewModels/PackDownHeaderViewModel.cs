using Newtonsoft.Json;

namespace Mi9.Store.ViewModels.ViewModels
{
    public class PackDownHeaderViewModel
    {
        [JsonProperty("onHand")]
        public decimal OnHand { get; set; }

        [JsonProperty("onOrder")]
        public decimal OnOrder { get; set; }

        [JsonProperty("vendorPack")]
        public short VendorPack { get; set; }
    }
}
