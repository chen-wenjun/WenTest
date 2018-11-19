using Newtonsoft.Json;
using System;

namespace Mi9.Store.ViewModels.ViewModels
{
    [JsonObject(MemberSerialization.OptIn)]
    public class CompetitorViewModel
    {
        [JsonProperty(PropertyName = "competitorID")]
        public long CompetitorID{ get;set; }

        [JsonProperty(PropertyName="competitorName")]
         public string Name { get; set; }

        [JsonProperty(PropertyName="address")]
        public string Address { get; set; }

        [JsonProperty(PropertyName="city")]
        public string City { get; set; }

        [JsonProperty(PropertyName="phone")]
        public string Phone { get; set; }       
    }

    public class CompetitorItemViewModel
    {
        [JsonProperty(PropertyName = "competitorID")]
        public long CompetitorID { get; set; }

        [JsonProperty(PropertyName = "brand")]
        public string Brand { get; set; }

        [JsonProperty(PropertyName = "quoteProvided")]
        public bool QuoteProvided { get; set; }

        [JsonProperty(PropertyName = "date")]
        public DateTime? Date { get; set; }

        [JsonProperty(PropertyName = "price")]
        public decimal? Price { get; set; }
    }
}
