using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Mi9.Store.ViewModels.ViewModels
{
    public class PhyInvPreCountMainViewModel
    {
        public IEnumerable<PhyInvPreCountSchedViewModel> PreCountsScheduler { get; set; }

        public string PhysicalInventoryStatus { get; set; }

        [JsonProperty(PropertyName="weeks")]
        public IEnumerable<PhyInvPreCountWeekViewModel> Weeks { get; set; }

        [JsonProperty(PropertyName = "countWeeks")]
        public int CountWeeks { get; set; }

        [JsonProperty(PropertyName = "countId")]
        public int CountId { get; set; }

        [JsonProperty(PropertyName = "targetCompletion")]
        public DateTime? TargetCompletion { get; set; }
    }
}
