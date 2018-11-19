using Newtonsoft.Json;

namespace Mi9.Store.ViewModels.ViewModels
{
    [JsonObject(MemberSerialization.OptIn)]
    public class StateViewModel
    {
        
        [JsonProperty(PropertyName = "abbr")]
        public string Id { get; set; }

        [JsonProperty(PropertyName = "stateName")]
        public string StateName { get; set; }

        [JsonProperty(PropertyName = "name")]
        public string FullName
        {
            get
            {
                return this.StateName + ", " + this.Id;
            }
        }

        [JsonProperty(PropertyName = "country")]
        public short CountryId { get; set; }
    }
}
