using System;
using Mi9.Store.ViewModels.Converters;
using Newtonsoft.Json;

namespace Mi9.Store.ViewModels.ViewModels
{
   
    [JsonObject(MemberSerialization.OptIn)]
    public class ReceivingHoursViewModel
    {
        [JsonProperty(PropertyName = "id")]
        public int Id { get; set; }

        [JsonProperty(PropertyName = "startDate")]
        [JsonConverter(typeof(TimeSpanAmPmConverter))]
        public TimeSpan StartDate { get; set; }

        [JsonProperty(PropertyName = "endDate")]
        [JsonConverter(typeof(TimeSpanAmPmConverter))]
        public TimeSpan EndDate { get; set; }

        [JsonProperty(PropertyName = "mondayAvailable")]
        public bool MondayAvailable { get; set; }

        [JsonProperty(PropertyName = "tuesdayAvailable")]
        public bool TuesdayAvailable { get; set; }

        [JsonProperty(PropertyName = "wednesdayAvailable")]
        public bool WednesdayAvailable { get; set; }

        [JsonProperty(PropertyName = "thursdayAvailable")]
        public bool ThursdayAvailable { get; set; }

        [JsonProperty(PropertyName = "fridayAvailable")]
        public bool FridayAvailable { get; set; }

        [JsonProperty(PropertyName = "saturdayAvailable")]
        public bool SaturdayAvailable { get; set; }

        [JsonProperty(PropertyName = "sundayAvailable")]
        public bool SundayAvailable { get; set; }
    }
}
