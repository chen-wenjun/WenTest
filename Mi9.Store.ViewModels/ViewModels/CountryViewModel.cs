
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Mi9.Store.ViewModels.ViewModels
{
    [JsonObject(MemberSerialization.OptIn)]
    public class CountryViewModel
    {
        [JsonProperty(PropertyName = "id")]
        public short Id { get; set; }

        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        [JsonProperty(PropertyName = "code")]
        public string Code { get; set; }

        [JsonProperty(PropertyName = "definition")]
        public CountryDefinitionViewModel Definition { get; set; }

        [JsonProperty(PropertyName = "states")]
        public List<StateViewModel> States { get; set; } 
    }
}
