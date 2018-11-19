using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Mi9.Store.ViewModels.ViewModels
{
    public class ShipmentViewModel
    {
        [JsonProperty(PropertyName = "shipmentNumber")]
        public string ShipmentNumber { get; set; }

        [JsonProperty(PropertyName = "shipmentType")]
        public string ShipmentType { get; set; }

        [JsonProperty(PropertyName = "poNumber")]
        public string PurchaseOrderNumber { get; set; }

        [JsonProperty(PropertyName = "lastDateReceived")]
        public DateTime LastDateReceived { get; set; }

        [JsonProperty(PropertyName = "from")]
        public string From { get; set; }

        [JsonProperty(PropertyName = "to")]
        public string StoreName { get; set; }

        [JsonProperty(PropertyName = "bolMissing")]
        public bool BolMissing { get; set; }

        [JsonProperty(PropertyName = "carrierBillMissing")]
        public bool CarrierBillMissing { get; set; }

        [JsonProperty(PropertyName = "photoMissing")]
        public bool PhotoMissing { get; set; }

        [JsonProperty(PropertyName = "manifestMissing")]
        public bool ManifestMissing { get; set; }

        [JsonProperty(PropertyName = "tripLogMissing")]
        public bool TripLogMissing { get; set; }

        [JsonProperty(PropertyName = "complete")]
        public bool Complete { get; set; }

        [JsonProperty(PropertyName = "marchamo")]
        public bool ConsistentMarking { get; set; }

        [JsonProperty(PropertyName = "catsWellPlaced")]
        public bool CatsWellPlaced { get; set; }

        [JsonProperty(PropertyName = "enoughCats")]
        public bool EnoughCats { get; set; }

        [JsonProperty(PropertyName = "barsWellPlaced")]
        public bool BarsWellPlaced { get; set; }

        [JsonProperty(PropertyName = "enoughBars")]
        public bool EnoughBars { get; set; }

        [JsonProperty(PropertyName = "suitableArrange")]
        public bool SuitableArrange { get; set; }

        [JsonProperty(PropertyName = "pallets")]
        public IEnumerable<PalletHeaderViewModel> Pallets { get; set; }

        [JsonProperty(PropertyName = "notesAndHistory")]
        public NotesAndHistoryViewModel NotesAndHistory { get; set; }

        [JsonProperty(PropertyName = "status")]
        public string Status { get; set; }
    }
}