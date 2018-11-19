using System.Collections.Generic;
using Newtonsoft.Json;

namespace Mi9.Store.ViewModels.ViewModels
{
    public class LaborManagementEmployeeTwoMonthAbsenceViewModel
    {
        [JsonProperty(PropertyName = "firstMonth")]
        public IEnumerable<LaborManagementEmployeeDayAbsenceViewModel> FirstMonth { get; set; }

        [JsonProperty(PropertyName = "secondMonth")]
        public IEnumerable<LaborManagementEmployeeDayAbsenceViewModel> SecondMonth { get; set; }
    }
}
