using System;
using Newtonsoft.Json;

namespace Mi9.Store.ViewModels.ViewModels
{
    [JsonObject(MemberSerialization.OptIn)]
    public class WeekDayViewModel
    {
        public int EmployeeId { get; set; }

        [JsonProperty(PropertyName = "hours")]
        public decimal Hours { get; set; }

        [JsonProperty(PropertyName = "incidentId")]
        public int? IncidentId { get; set; }

        [JsonProperty(PropertyName = "incidentType")]
        public virtual IncidentTypeViewModel IncidentType { get; set; }

        [JsonProperty(PropertyName = "isTimeOff")]
        public bool IsTimeOff { get; set; }

        [JsonProperty(PropertyName = "date")]
        public DateTime Date { get; set; }
    }
}
