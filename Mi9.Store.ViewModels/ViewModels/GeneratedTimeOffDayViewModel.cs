namespace Mi9.Store.ViewModels.ViewModels 
{
    using Newtonsoft.Json;

    public class GeneratedTimeOffDayViewModel
    {
        [JsonProperty(PropertyName = "val")]
        public bool IsTimeOff { get; set; }

        [JsonProperty(PropertyName = "reason")]
        public string Reason { get; set; }
    }
}
