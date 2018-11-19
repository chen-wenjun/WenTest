using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Mi9.Store.ViewModels.ViewModels
{
    public class LaborManagementEmployeeDayAbsenceViewModel
    {
        [JsonProperty(PropertyName = "date")]
        public DateTime Date { get; set; }

        [JsonProperty(PropertyName = "dayOfMonth")]
        public int DayOfMonth { get; set; }

        [JsonProperty(PropertyName = "dayOfWeek")]
        public int DayOfWeek { get; set; }

        [JsonProperty(PropertyName = "reasonId")]
        public int? ReasonId { get; set; }

        [JsonProperty(PropertyName = "trainingHours")]
        public IEnumerable<bool> TrainingHours { get; set; } 

    }
}
