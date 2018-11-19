using Newtonsoft.Json;

namespace Mi9.Store.ViewModels.ViewModels
{
    [JsonObject(MemberSerialization.OptIn)]
    public class FixedTimeOffViewModel
    {
        [JsonProperty(PropertyName = "empId")]
        public int EmployeeId { get; set; }

        [JsonProperty(PropertyName = "seq")]
        public int SequenceNumber { get; set; }

        [JsonProperty(PropertyName = "empName")]
        public string EmployeeFullName { get; set; }

        [JsonProperty(PropertyName = "empStatus")]
        public string EmployeeState { get; set; }

        [JsonProperty(PropertyName = "monday")]
        public FixedTimeOffDayViewModel Monday { get; set; }

        [JsonProperty(PropertyName = "tuesday")]
        public FixedTimeOffDayViewModel Tuesday { get; set; }

        [JsonProperty(PropertyName = "wednesday")]
        public FixedTimeOffDayViewModel Wednesday { get; set; }

        [JsonProperty(PropertyName = "thursday")]
        public FixedTimeOffDayViewModel Thursday { get; set; }

        [JsonProperty(PropertyName = "friday")]
        public FixedTimeOffDayViewModel Friday { get; set; }

        [JsonProperty(PropertyName = "saturday")]
        public FixedTimeOffDayViewModel Saturday { get; set; }

        [JsonProperty(PropertyName = "sunday")]
        public FixedTimeOffDayViewModel Sunday { get; set; }
    }
}
