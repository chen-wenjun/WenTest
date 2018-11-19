using Newtonsoft.Json;

namespace Mi9.Store.ViewModels.ViewModels
{
   public class DistrictViewModel
    {
        [JsonProperty(PropertyName = "code")]
        public string DistrictCode { get; set; }

        [JsonProperty(PropertyName = "name")]
        public string DistrictName { get; set; }
    }
}
