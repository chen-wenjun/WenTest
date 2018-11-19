using System.Collections.Generic;
using Newtonsoft.Json;

namespace Mi9.Store.ViewModels.ViewModels
{
    public class GeneratedSchedulePutViewModel
    {
        [JsonProperty(PropertyName = "laborId")]
        public int EmployeeId { get; set; }

        [JsonProperty(PropertyName = "weekDay")]
        public string DayOfWeek { get; set; }

        [JsonProperty(PropertyName = "week")]
        public int WeekId { get; set; }

        [JsonProperty(PropertyName = "empStatus")]
        public string EmpStatus { get; set; }

        [JsonProperty(PropertyName = "hours")]
        public List<ScheduleDayPutViewModels> Hours { get; set; }
    }
}
