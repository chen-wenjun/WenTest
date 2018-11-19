using System;
using Newtonsoft.Json;

namespace Mi9.Store.ViewModels.ViewModels
{
    public class PhyInvPreCountSchedFilterViewModel
    {
        [JsonProperty(PropertyName = "Number")]
        public int? Week { get; set; }

        [JsonProperty(PropertyName = "Date")]
        public DateTime? WeekStartDate { get; set; }

        [JsonProperty(PropertyName = "idZone")]
        public string IdZone { get; set; }

        [JsonProperty(PropertyName = "from")]
        public string BayFrom { get; set; }

        [JsonProperty(PropertyName = "to")]
        public string BayTo { get; set; }
    }
}
