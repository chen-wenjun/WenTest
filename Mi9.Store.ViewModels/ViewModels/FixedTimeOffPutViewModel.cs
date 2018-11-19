using System.Collections.Generic;
using Newtonsoft.Json;

namespace Mi9.Store.ViewModels.ViewModels
{    
    [JsonObject(MemberSerialization.OptIn)]
    public class FixedTimeOffPutViewModel
    {
        [JsonProperty(PropertyName = "laborId")]
        public int EmployeeId { get; set; }

        [JsonProperty(PropertyName = "days")]
        public List<bool> Days { get; set; }
    }
}
