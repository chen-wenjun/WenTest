using Newtonsoft.Json;

namespace Mi9.Store.ViewModels.ViewModels
{
    public class ReasonViewModel
    {
        [JsonProperty(PropertyName = "id")]
        public byte ReasonCode { get; set; }

        [JsonIgnore]
        public string AdjustType { get; set; }

        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }

        [JsonIgnore]
        public string InvAdjMeth { get; set; }

        [JsonProperty(PropertyName = "effect")]
        public bool Effect
        {
            get
            {
                switch (InvAdjMeth)
                {
                    case "A":
                        return true;
                    default:
                        return false;
                }
            }
        }
        
        [JsonProperty(PropertyName = "conversion")]
        public bool Conversion { get; set; }
    }
}