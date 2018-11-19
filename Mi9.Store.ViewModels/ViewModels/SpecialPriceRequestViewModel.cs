using Mi9.Store.ViewModels.Converters;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace Mi9.Store.ViewModels.ViewModels
{
    [JsonObject(MemberSerialization.OptIn)]
    public class SpecialPriceRequestViewModel
    {
        [JsonProperty(PropertyName = "id")]
        public int Id { get; set; }

        [JsonProperty(PropertyName = "reason")]
        public string Reason { get; set; }

        [JsonProperty(PropertyName = "status")]
        public string Status { get; set; }

        [JsonProperty(PropertyName = "needCallback")]
        public bool NeedCallback { get; set; }

        [JsonProperty(PropertyName = "orderNumber")]
        public int OrderNumber { get; set; }

        [JsonProperty(PropertyName = "isRegionalManagerAvailable")]
        public bool IsRegionalManagerAvailable { get; set; }

        [JsonProperty(PropertyName = "created")]
        [JsonConverter(typeof(IsoUtcDateTimeConverter))]
        public DateTime Created { get; set; }

        [JsonProperty(PropertyName = "StoreStatus")]
        public string StoreStatus { get; set; }

        [JsonProperty(PropertyName = "RegionalStatus")]
        public string RegionalStatus { get; set; }

        [JsonProperty(PropertyName = "NationalStatus")]
        public string NationalStatus { get; set; }

        [JsonProperty(PropertyName = "items")]
        public List<SkuRequestItemViewModel> Items { get; set; }
    }
}