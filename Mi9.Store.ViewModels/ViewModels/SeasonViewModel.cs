using System;
using Newtonsoft.Json;

namespace Mi9.Store.ViewModels.ViewModels
{
    [JsonObject(MemberSerialization.OptIn)]
    public class SeasonViewModel
    {
        [JsonProperty(PropertyName = "id")]
        public byte Id { get; set; }

        [JsonProperty(PropertyName = "startOfSeason")]
        public DateTime StartSeason { get; set; }

        [JsonProperty(PropertyName = "endOfSeason")]
        public DateTime EndSeason { get; set; }
    }
}
