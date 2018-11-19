using System.Collections.Generic;
using Newtonsoft.Json;

namespace Mi9.Store.ViewModels.ViewModels
{
    public class LaborManagementEmployeeScheduleCatalogsViewModel
    {
        [JsonProperty(PropertyName = "jobClasses")]
        public IEnumerable<JobClassViewModel> JobClasses { get; set; }

        [JsonProperty(PropertyName = "weeks")]
        public IEnumerable<WeekViewModel> Weeks { get; set; }
    }
}
