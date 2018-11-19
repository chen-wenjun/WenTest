using System.Collections.Generic;
using Newtonsoft.Json;

namespace Mi9.Store.ViewModels.ViewModels
{
   
    public class FixedSchedulePrintViewModel
    {
        [JsonProperty(PropertyName = "empId")]
        public int EmployeeId { get; set; }

        [JsonProperty(PropertyName = "seq")]
        public int SequenceNumber { get; set; }

        [JsonProperty(PropertyName = "empName")]
        public string EmployeeFullName { get; set; }

        [JsonProperty(PropertyName = "empStatus")]
        public string EmployeeState { get; set; }

        public byte DayOfWeek { get; set; }

        [JsonProperty(PropertyName = "intervals")]
        public List<List<string>> TimeIntervals { get; set; }

        [JsonProperty(PropertyName = "total")]
        public decimal Total { get; set; }
    }
}
