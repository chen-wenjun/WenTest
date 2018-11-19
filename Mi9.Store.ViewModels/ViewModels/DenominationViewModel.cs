using Newtonsoft.Json;

namespace Mi9.Store.ViewModels.ViewModels
{
    public class DenominationViewModel
    {
        [JsonProperty(PropertyName = "id")]
        public int DenominationId { get; set; }

        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }

        [JsonProperty(PropertyName = "displayOrder")]
        public int DisplayOrder { get; set; }

        [JsonProperty(PropertyName = "value")]
        public decimal Price { get; set; }

        [JsonProperty(PropertyName = "isCustomPrice")]
        public bool IsCustom { get; set; }

        [JsonProperty(PropertyName = "isDynamic")]
        public bool IsDynamic { get; set; }

        [JsonProperty(PropertyName = "isActive")]
        public bool IsActive { get; set; }

        [JsonProperty(PropertyName = "tenderType")]
        public TenderTypeViewModel TenderType { get; set; }

        [JsonProperty(PropertyName = "tender")]
        public TenderViewModel Tender { get; set; }

        public bool ShouldSerializeTender()
        {
            return Tender != null;
        }
    }
}