using System.Collections.Generic;
using Newtonsoft.Json;

namespace Mi9.Store.ViewModels.ViewModels
{
    public class FixedScheduleViewModel
    {
        [JsonProperty(PropertyName = "empId")]
        public int EmployeeId { get; set; }

        [JsonProperty(PropertyName = "payrollId")]
        public string PayrollId { get; set; }

        [JsonProperty(PropertyName = "seq")]
        public int SequenceNumber { get; set; }

        [JsonProperty(PropertyName = "empName")]
        public string EmployeeFullName { get; set; }

        [JsonProperty(PropertyName = "empStatus")]
        public string EmployeeState { get; set; }

        [JsonProperty(PropertyName = "hours")]
        public List<ScheduleDayViewModel> Hours { get; set; }

        public byte DayOfWeek { get; set; }

        [JsonProperty(PropertyName = "daysOff")]
        public int[] DaysOff { get; set; }
    }
}