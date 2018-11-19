using System.Collections.Generic;
using Newtonsoft.Json;

namespace Mi9.Store.ViewModels.ViewModels
{
    public class ScheduleSelectedDaysViewModel
    {
        [JsonProperty(PropertyName = "days")]
        public IEnumerable<IEnumerable<ScheduleSelectedDayViewModel>> Days { get; set; }

        [JsonProperty(PropertyName = "canSaved")]
        public bool CanSaved { get; set; }
    }
}
