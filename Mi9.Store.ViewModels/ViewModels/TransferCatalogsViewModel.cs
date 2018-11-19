using System.Collections.Generic;
using Mi9.Store.ViewModels.ViewModels.Enums;
using Newtonsoft.Json;

namespace Mi9.Store.ViewModels.ViewModels
{
    public class TransferCatalogsViewModel
    {
        [JsonProperty(PropertyName = "requestStore")]
        public StoreViewModel RequestStore { get; set; }

        [JsonProperty(PropertyName = "sendingLocationTypes")]
        public IEnumerable<SendingLocationType> SendigLocationTypes { get; set; }

        [JsonProperty(PropertyName = "reasons")]
        public IEnumerable<ReasonCodeViewModel> Reasons { get; set; }

        [JsonProperty(PropertyName = "shipMethods")]
        public IEnumerable<ShipMethodViewModel> ShipMethods { get; set; }

        [JsonProperty(PropertyName = "skuStatusCodes")]
        public IEnumerable<SkuStatusCode> SkuStatusCodes { get; set; }

        [JsonProperty(PropertyName = "skuUniqueItemCodes")]
        public IEnumerable<SkuUniqueItemCode> SkuUniqueItemCodes { get; set; }
        
    }
}
