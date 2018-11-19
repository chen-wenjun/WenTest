using System.Collections.Generic;
using Newtonsoft.Json;

namespace Mi9.Store.ViewModels.ViewModels
{
    public class CmAdjustViewModel
    {
        [JsonProperty(PropertyName = "adjustReason")]
        public string AdjustReason { get; set; }

        [JsonProperty(PropertyName = "tenders")]
        public virtual IEnumerable<CmMaintenanceDetailViewModel> Tenders { get; set; }
    }
}
