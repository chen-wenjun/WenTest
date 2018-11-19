using System.Collections.Generic;
using Newtonsoft.Json;

namespace Mi9.Store.ViewModels.ViewModels
{
    public class PhyInvsImportedDataViewModel
    {
        public int Part { get; set; }
        public IEnumerable<PhyInvsImportTempViewModel> Items { get; set; }
    }

    public class PhyInvsImportTempViewModel
    {
        [JsonProperty(PropertyName = "section")]
        public int Section { get; set; }
            
        [JsonProperty(PropertyName = "area")]
        public int Area { get; set; }

        [JsonProperty(PropertyName = "zone")]
        public string Zone { get; set; }

        [JsonProperty(PropertyName = "bay")]
        public string Bay { get; set; }
            
        [JsonProperty(PropertyName = "dept")]
        public int Department { get; set; }
            
        [JsonProperty(PropertyName = "sku")]
        public long Sku { get; set; }

        [JsonProperty(PropertyName = "altSku")]
        public long? AlternateSku { get; set; }

        [JsonProperty(PropertyName = "breakdown")]
        public int Breakdown { get; set; }

        [JsonProperty(PropertyName = "retailPrice")]
        public decimal RetailPrice { get; set; }

        [JsonProperty(PropertyName = "avgCost")]
        public decimal AverageCost { get; set; }

        [JsonProperty(PropertyName = "onHandQty")]
        public int OnHandQuantity { get; set; }
            
        [JsonProperty(PropertyName = "status")]
        public string Status { get; set; }

        [JsonProperty(PropertyName = "velocityCode")]
        public string VelocityCode { get; set; }
    }
}
