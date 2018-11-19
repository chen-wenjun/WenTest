using System.Collections.Generic;
using Newtonsoft.Json;

namespace Mi9.Store.ViewModels.ViewModels
{
    [JsonObject(MemberSerialization.OptIn)]
    public class LaborPutViewModel
    {
        [JsonProperty(PropertyName = "laborId")]
        public int LabourId { get; set; }

        [JsonProperty(PropertyName = "days")]
        public List<WeekDayPutViewModel> WeekDays { get; set; }
    }
}
