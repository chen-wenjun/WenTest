using Newtonsoft.Json;

namespace Mi9.Store.ViewModels.ViewModels
{
    public class VendorPreviewModel
    {
        [JsonProperty(PropertyName = "id")]
        public string VendorId { get; set; }

        [JsonProperty(PropertyName = "suffix")]
        public byte VendorSuffix { get; set; }

        [JsonProperty(PropertyName = "name")]
        public string VendorName { get; set; }

        [JsonProperty(PropertyName = "department")]
        public DepartmentViewModel Department { get; set; }

        [JsonProperty(PropertyName = "isActive")]
        public bool IsActive { get; set; }

        [JsonProperty(PropertyName = "isSpecialOrder")]
        public bool SpecificationsRequired { get; set; }
    }
}
