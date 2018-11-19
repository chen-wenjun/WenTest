
using System;
using System.Collections.Generic;
using Mi9.Store.ViewModels.Converters;
using Mi9.Store.ViewModels.ViewModels.Enums.Handheld;
using Newtonsoft.Json;

namespace Mi9.Store.ViewModels.ViewModels
{
    public class InventoryInquiryRequestViewModel
    {
        [JsonProperty(PropertyName = "store")]
        public short? StoreNumber { get; set; }

        [JsonProperty(PropertyName = "date")]
        [JsonConverter(typeof(IsoUtcDateTimeConverter))]
        public DateTime BusinessDate { get; set; }

        [JsonProperty(PropertyName = "items")]
        public ICollection<InventoryInquirySkuRequestViewModel> Items { get; set; }

        [JsonProperty(PropertyName = "locationType")]
        public LocationTypeEnum LocationType { get; set; }
    }
}
