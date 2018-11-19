using System.Collections.Generic;
using Newtonsoft.Json;

namespace Mi9.Store.ViewModels.ViewModels
{
    public class LaborManagementEmployeeMaintenanceCatalogsViewModel
    {
        [JsonProperty(PropertyName = "reasonTypes")]
        public IEnumerable<ReasonTypeViewModel> ReasonTypes { get; set; }

        [JsonProperty(PropertyName = "jobClasses")]
        public IEnumerable<JobClassViewModel> JobClasses { get; set; }

    }
}
