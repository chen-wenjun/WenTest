using Newtonsoft.Json;

namespace Mi9.Store.ViewModels.ViewModels
{
    public class PoTrackingUserViewModel
    {
        [JsonProperty("fullName")]
        public string FullName { get; set; }
        [JsonProperty("payrollId")]
        public string PayrollId { get; set; }
    }

    
}
