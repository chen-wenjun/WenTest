using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Mi9.Store.ViewModels.ViewModels
{
    public class PalletHeaderViewModel
    {
        [JsonProperty(PropertyName = "storeNumber")]
        public short StoreNumber { get; set; }

        [JsonProperty(PropertyName = "palletId")]
        public string PalletId { get; set; }

        [JsonProperty(PropertyName = "shipmentNumber")]
        public string ShipmentNumber { get; set; }

        [JsonProperty(PropertyName = "auditStatus")]
        public string AuditStatus { get; set; }

        [JsonProperty(PropertyName = "stretchWrap")]
        public bool StretchWrap { get; set; }

        [JsonProperty(PropertyName = "consolidation")]
        public bool Consolidation { get; set; }

        [JsonProperty(PropertyName = "goodCondition")]
        public bool GoodCondition { get; set; }

        [JsonProperty(PropertyName = "goodTie")]
        public bool GoodTie { get; set; }

        [JsonProperty(PropertyName = "error")]
        public bool Error { get; set; }

        [JsonProperty(PropertyName = "scanned")]
        public bool Scanned { get; set; }

        [JsonProperty(PropertyName = "storeAudit")]
        public bool StoreAudit { get; set; }

        [JsonProperty(PropertyName = "systemAudit")]
        public bool SystemAudit { get; set; }

        //computed viewmodel properties 

        [JsonProperty(PropertyName = "totalNumberOfSku")]
        public int TotalNumberOfSku { get; set; }

        [JsonProperty(PropertyName = "totalQuantity")]
        public decimal TotalQuantity { get; set; }

        [JsonProperty(PropertyName = "totalCost")]
        public decimal TotalCost { get; set; }

        [JsonProperty(PropertyName = "masterLabel")]
        public string MasterLabel { get; set; }

        [JsonProperty(PropertyName = "UpdatedOn")]
        public DateTime? UpdatedOn { get; set; }

        [JsonProperty(PropertyName = "UpdatedById")]
        public int? UpdatedById { get; set; }

        [JsonProperty(PropertyName = "type")]
        public string Type { get; set; }

        [JsonProperty(PropertyName = "printedLabelOriginalDate")]
        public DateTime? PrintedLabelOriginalDate { get; set; }

        [JsonProperty(PropertyName = "items")]
        public IEnumerable<PalletDetailViewModel> Items { get; set; }

        [JsonProperty(PropertyName = "shipmentStatus")]
        public string ShipmentStatus { get; set; }
    }
}