using Newtonsoft.Json;

namespace Mi9.Store.ViewModels.ViewModels
{
    public class WeekDayPutViewModel
    {
        [JsonProperty(PropertyName = "day")]
        public string DayName { get; set; }

        [JsonProperty(PropertyName = "statusId")]
        public string StateId { get; set; }
    }
}
