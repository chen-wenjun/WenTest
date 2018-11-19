using Newtonsoft.Json;

namespace Mi9.Store.ViewModels.ViewModels
{
    [JsonObject(MemberSerialization.OptIn)]
    public class FixedTimeOffDayViewModel
    {
        [JsonProperty(PropertyName = "val")]
        public bool IsTimeOff { get; set; }
    }
}
