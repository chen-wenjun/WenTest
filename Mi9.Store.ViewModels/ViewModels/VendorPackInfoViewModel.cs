using Newtonsoft.Json;

namespace Mi9.Store.ViewModels.ViewModels
{
    public class VendorPackInfoViewModel
    {
        [JsonProperty(PropertyName = "vendUomQty")]
        public short VendUomQty { get; set; }
        [JsonProperty(PropertyName = "vendUom")]
        public string VendUom { get; set; }
    }
}
