using Newtonsoft.Json;

namespace Mi9.Store.ViewModels.ViewModels
{
    [JsonObject(MemberSerialization.OptIn)]
    public class ScheduleDayPutViewModels
    {
        [JsonProperty(PropertyName = "val")]
        public string Hour { get; set; }

        [JsonProperty(PropertyName = "isOverNight")]
        public bool IsOverNight { get; set; }
    }
}