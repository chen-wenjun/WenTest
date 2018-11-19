using Newtonsoft.Json;

namespace Mi9.Store.ViewModels.ViewModels
{
    [JsonObject(MemberSerialization.OptIn)]
    public class ScheduleSelectedDayViewModel
    {
        [JsonProperty(PropertyName = "val")]
        public string Value { get; set; }

        [JsonProperty(PropertyName = "selected")]
        public bool Selected { get; set; }
    }
}
