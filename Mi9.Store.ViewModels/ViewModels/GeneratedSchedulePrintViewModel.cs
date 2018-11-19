using System;
using System.Collections.Generic;
using MI9.HDM.Store.BackOffice.Core;
using Mi9.Store.ViewModels.Converters;
using Newtonsoft.Json;

namespace Mi9.Store.ViewModels.ViewModels
{
    public class GeneratedSchedulePrintViewModel
    {
        [JsonProperty(PropertyName = "empId")]
        public int EmployeeId { get; set; }

        [JsonConverter(typeof(IsoUtcDateTimeConverter))]
        [JsonProperty(PropertyName = "startDate")]
        public DateTime StartDate { get; set; }

        [JsonProperty(PropertyName = "seq")]
        public int SequenceNumber { get; set; }

        [JsonProperty(PropertyName = "empName")]
        public string EmployeeFullName { get; set; }

        [JsonProperty(PropertyName = "empStatus")]
        public string EmployeeState { get; set; }

        [JsonProperty(PropertyName = "intervals")]
        public List<List<string>> TimeIntervals { get; set; } 

        [JsonProperty(PropertyName = "dayOfWeek")]
        public byte DayOfWeek { get; set; }

        [JsonProperty(PropertyName = "total")]
        public decimal Total { get; set; }
    }
}