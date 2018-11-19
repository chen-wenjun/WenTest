using System;
using Newtonsoft.Json;

namespace Mi9.Store.ViewModels.ViewModels
{
    [JsonObject(MemberSerialization.OptIn)]
    public class GeneratedTimeOffViewModel
    {
        [JsonProperty(PropertyName = "id")]
        public int Id { get; set; }

        public DateTime StartDate { get; set; }

        [JsonProperty(PropertyName = "weekId")]
        public int WeekId { get; set; }

        [JsonProperty(PropertyName = "seq")]
        public int SequenceNumber { get; set; }

        [JsonProperty(PropertyName = "empId")]
        public int EmployeeId { get; set; }

        [JsonProperty(PropertyName = "empName")]
        public string EmployeeFullName { get; set; }

        [JsonProperty(PropertyName = "empStatus")]
        public string EmployeeState { get; set; }

        [JsonProperty(PropertyName = "monday")]
        public GeneratedTimeOffDayViewModel Monday { get; set; }

        [JsonProperty(PropertyName = "tuesday")]
        public GeneratedTimeOffDayViewModel Tuesday { get; set; }

        [JsonProperty(PropertyName = "wednesday")]
        public GeneratedTimeOffDayViewModel Wednesday { get; set; }

        [JsonProperty(PropertyName = "thursday")]
        public GeneratedTimeOffDayViewModel Thursday { get; set; }

        [JsonProperty(PropertyName = "friday")]
        public GeneratedTimeOffDayViewModel Friday { get; set; }

        [JsonProperty(PropertyName = "saturday")]
        public GeneratedTimeOffDayViewModel Saturday { get; set; }

        [JsonProperty(PropertyName = "sunday")]
        public GeneratedTimeOffDayViewModel Sunday { get; set; }
    }
}