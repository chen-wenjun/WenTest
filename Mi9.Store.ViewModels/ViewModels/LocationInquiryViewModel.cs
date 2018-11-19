using System.Collections.Generic;
using Newtonsoft.Json;

namespace Mi9.Store.ViewModels.ViewModels
{
    public class LocationInquiryViewModel
    {
        [JsonProperty(PropertyName = "requestStoreCompoundName")]
        public string RequestStoreCompoundName { get; set; }

        [JsonProperty(PropertyName = "requestStoreDistrict")]
        public DistrictViewModel RequestStoreDistrict { get; set; }

        [JsonProperty(PropertyName = "sourceStores")]
        public IEnumerable<DestinationViewModel> SourceStores { get; set; }

    }
}
