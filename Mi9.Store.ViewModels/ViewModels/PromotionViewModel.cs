using System;
using Mi9.Store.ViewModels.Converters;
using Newtonsoft.Json;

namespace Mi9.Store.ViewModels.ViewModels
{
    [JsonObject(MemberSerialization.OptIn)]
    public class PromotionViewModel
    {
        [JsonProperty(PropertyName = "number")]
        public long Sku { get; set; }

        [JsonProperty(PropertyName = "promotionId")]
        public int PromotionId { get; set; }

        [JsonProperty(PropertyName = "title")]
        public string PromotionTitle
        {
            get
            {
                var title = string.Format("{0} {1}.", "Promotion", PromotionId);
                return title;
            }
        }

        [JsonProperty(PropertyName = "promoPrice")]
        public decimal PromoPrice { get; set; }

        [JsonProperty(PropertyName = "startDate")]
        [JsonConverter(typeof(IsoUtcDateTimeConverter))]
        public DateTime? StartDate { get; set; }

        [JsonProperty(PropertyName = "endDate")]
        [JsonConverter(typeof(IsoUtcDateTimeConverter))]
        public DateTime? EndDate { get; set; }

        [JsonProperty(PropertyName = "promoType")]
        public byte PromoType { get; set; }
    }
}