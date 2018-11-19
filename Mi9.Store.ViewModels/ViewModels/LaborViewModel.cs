using System;
using Newtonsoft.Json;

namespace Mi9.Store.ViewModels.ViewModels
{
    [JsonObject(MemberSerialization.OptIn)]
    public class LaborViewModel
    {
        [JsonProperty(PropertyName = "id")]
        public int Id { get; set; }

        public DateTime StartDate { get; set; }

        [JsonProperty(PropertyName = "seq")]
        public int SequenceNumber { get; set; }

        [JsonProperty(PropertyName = "empId")]
        public int EmployeeId { get; set; }

        [JsonProperty(PropertyName = "empName")]
        public string EmployeeFullName { get; set; }

        [JsonProperty(PropertyName = "empStatus")]
        public string EmployeeState { get; set; }

        [JsonProperty(PropertyName = "monday")]
        public WeekDayViewModel Monday { get; set; }

        [JsonProperty(PropertyName = "tuesday")]
        public WeekDayViewModel Tuesday { get; set; }

        [JsonProperty(PropertyName = "wednesday")]
        public WeekDayViewModel Wednesday { get; set; }

        [JsonProperty(PropertyName = "thursday")]
        public WeekDayViewModel Thursday { get; set; }

        [JsonProperty(PropertyName = "friday")]
        public WeekDayViewModel Friday { get; set; }

        [JsonProperty(PropertyName = "saturday")]
        public WeekDayViewModel Saturday { get; set; }

        [JsonProperty(PropertyName = "sunday")]
        public WeekDayViewModel Sunday { get; set; }
    }
}
