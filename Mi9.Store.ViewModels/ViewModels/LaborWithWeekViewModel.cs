using System.Collections.Generic;
using Newtonsoft.Json;

namespace Mi9.Store.ViewModels.ViewModels
{
    [JsonObject(MemberSerialization.OptIn)]
    public class LaborWithWeekViewModel
    {
        [JsonProperty(PropertyName = "department")]
        public short DepartmentId { get; set; }

        [JsonProperty(PropertyName = "week")]
        public string WeekId { get; set; }

        [JsonProperty(PropertyName = "changedLabors")]
        public List<LaborPutViewModel> Labours { get; set; }
    }
}
