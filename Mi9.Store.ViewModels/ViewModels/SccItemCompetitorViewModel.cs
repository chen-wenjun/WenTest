using System;
using Mi9.Store.ViewModels.Converters;
using Newtonsoft.Json;

namespace Mi9.Store.ViewModels.ViewModels
{
    [JsonObject(MemberSerialization.OptIn)]
    public class SccItemCompetitorViewModel
    {
        [JsonProperty(PropertyName = "id")]
        public int Id { get; set; }

        [JsonProperty(PropertyName = "brand")]
        public string Brand { get; set; }

        [JsonProperty(PropertyName = "quoteProvided")]
        public bool QuoteProvided { get; set; }

        [JsonProperty(PropertyName = "date")]
        [JsonConverter(typeof(IsoUtcDateTimeConverter))]
        public DateTime? Date { get; set; }

        [JsonProperty(PropertyName = "price")]
        public decimal? Price { get; set; }

        [JsonProperty(PropertyName = "sccItemId")]
        public int SccItemId { get; set; }

        [JsonProperty(PropertyName = "competitorID")]
        public int? CompetitorId { get; set; }
    }
}
