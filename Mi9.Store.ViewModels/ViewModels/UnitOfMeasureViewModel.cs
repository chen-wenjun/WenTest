using Newtonsoft.Json;

namespace Mi9.Store.ViewModels.ViewModels
{
   public class UnitOfMeasureViewModel
    {
        [JsonProperty(PropertyName = "uomId")]
        public string UomId { get; set; }

        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }
       
        [JsonProperty(PropertyName = "isFractionalQuantityAllowed")]
        public bool IsFractionalQuantityAllowed { get; set; }
    }
}