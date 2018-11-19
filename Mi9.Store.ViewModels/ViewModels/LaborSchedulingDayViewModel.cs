using Newtonsoft.Json;

namespace Mi9.Store.ViewModels.ViewModels
{

    public class LaborSchedulingDayViewModel
    {
        [JsonProperty(PropertyName = "val")]
        public string Value { get; set; }
    }
}
