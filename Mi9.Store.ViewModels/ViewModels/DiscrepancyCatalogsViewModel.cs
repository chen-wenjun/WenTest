using System.Collections.Generic;
using Mi9.Store.ViewModels.ViewModels.Enums;
using Newtonsoft.Json;

namespace Mi9.Store.ViewModels.ViewModels
{
    public class DiscrepancyCatalogsViewModel
    {
        [JsonProperty("discrepancyActions")]
        public IEnumerable<DiscrepancyAction> DiscrepancyActions { get; set; }

        [JsonProperty("discrepancyStatuses")]
        public IEnumerable<DiscrepancyStatus> DiscrepancyStatuses { get; set; }

        [JsonProperty("discrepancyTypes")]
        public IEnumerable<DiscrepancyType> DiscrepancyTypes { get; set; }

        [JsonProperty("shipmentMethods")]
        public IEnumerable<ShipmentMethod> ShipmentMethods { get; set; }

        [JsonProperty("shipmentTypes")]
        public IEnumerable<ShipmentType> ShipmentTypes { get; set; }

        [JsonProperty("skuStatusCodes")]
        public IEnumerable<SkuStatusCode> SkuStatusCodes { get; set; }
    }
}
