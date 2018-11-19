using System.Collections.Generic;
using Newtonsoft.Json;

namespace Mi9.Store.ViewModels.ViewModels
{
    public class CmPickUpSummaryViewModel
    {
        [JsonProperty(PropertyName = "totalRecords")]
        public int TotalRecords { get; set; }

        [JsonProperty(PropertyName = "pickUps")]
        public ICollection<CmPickUpViewModel> PickUps { get; set; }
    }
}
