using System.Collections.Generic;
using Newtonsoft.Json;

namespace Mi9.Store.ViewModels.ViewModels
{
    public class LaborManagementEmployeeIncidentsCatalogsViewModel
    {
        [JsonProperty(PropertyName = "jobClasses")]
        public IEnumerable<JobClassViewModel> JobClasses { get; set; }

        [JsonProperty(PropertyName = "incidentTypes")]
        public IEnumerable<string> IncidentTypes { get; set; }

        [JsonProperty(PropertyName = "weeks")]
        public IEnumerable<WeekViewModel> Weeks { get; set; }
    }
}
