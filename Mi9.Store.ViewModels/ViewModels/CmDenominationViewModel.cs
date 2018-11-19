using Newtonsoft.Json;

namespace Mi9.Store.ViewModels.ViewModels
{
    public class CmDenominationViewModel
    {
        [JsonProperty(PropertyName = "id")]
        public int Id { get; set; }
        [JsonProperty(PropertyName = "value")]
        public decimal Value { get; set; }
    }
}
