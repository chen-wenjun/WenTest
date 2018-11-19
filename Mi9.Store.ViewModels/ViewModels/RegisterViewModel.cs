using Newtonsoft.Json;

namespace Mi9.Store.ViewModels.ViewModels
{
    [JsonObject(MemberSerialization.OptIn)]
    public class RegisterViewModel
    {
        [JsonProperty(PropertyName = "id")]
        public short RegisterId { get; set; }

        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }
    }
}
