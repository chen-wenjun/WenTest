using System.Collections.Generic;
using Newtonsoft.Json;

namespace Mi9.Store.ViewModels.ViewModels
{
    [JsonObject(MemberSerialization.OptIn)]
    public class FixedSchedulePutViewModel
    {
        [JsonProperty(PropertyName = "laborId")]
        public int EmployeeId { get; set; }

        [JsonProperty(PropertyName = "weekDay")]
        public string DayOfWeek { get; set; }

        [JsonProperty(PropertyName = "hours")]
        public List<ScheduleDayPutViewModels> Hours { get; set; }
    }
}