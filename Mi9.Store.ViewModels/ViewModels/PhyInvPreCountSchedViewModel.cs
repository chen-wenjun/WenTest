using System;
using Newtonsoft.Json;

namespace Mi9.Store.ViewModels.ViewModels
{
    public class PhyInvPreCountSchedViewModel
    {
        [JsonProperty(PropertyName = "id")]
        public int Id { get; set; }

        [JsonProperty(PropertyName = "zone")]
        public string Zone { get; set; }

        [JsonProperty(PropertyName = "bayNumber")]
        public string BayNumber { get; set; }

        [JsonProperty(PropertyName = "weekNo")]
        public Byte WeekNo { get; set; }

        [JsonProperty(PropertyName = "weekStartDate")]
        public DateTime WeekStartDate { get; set; }

        [JsonProperty(PropertyName = "retailValue")]
        public decimal RetailValue { get; set; }

        [JsonProperty(PropertyName = "status")]
        public string Status { get; set; }

        [JsonProperty(PropertyName = "deleted")]
        public bool Deleted { get; set; }
    }
}
