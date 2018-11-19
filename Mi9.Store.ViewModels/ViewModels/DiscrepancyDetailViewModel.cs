using System.Collections.Generic;
using Newtonsoft.Json;

namespace Mi9.Store.ViewModels.ViewModels
{
    public class DiscrepancyDetailViewModel
    {
        [JsonProperty("id")]
        public long Id { get; set; }

        [JsonProperty("sku")]
        public long SKU { get; set; }

        [JsonProperty("palletId")]
        public string PalletId { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("quantityShipped")]
        public int QuantityShipped { get; set; }

        [JsonProperty("quantityDisputed")]
        public int QuantityDisputed { get; set; }

        [JsonProperty("unitCost")]
        public decimal UnitCost { get; set; }

        [JsonProperty("retailPrice")]
        public decimal RetailPrice { get; set; }
        
        [JsonProperty("notes")]
        public string Notes { get; set; }

        [JsonProperty("action")]
        public int? Action { get; set; }

        [JsonProperty("attachments")]
        public virtual IEnumerable<DiscrepancyAttachmentViewModel> Attachments { get; set; }

        [JsonProperty("skuDescription")]
        public string SkuDescription { get; set; }

        [JsonProperty("skuStatus")]
        public string SkuStatus { get; set; }

        [JsonProperty("uploadedFileNames")]
        public IEnumerable<string> UploadedFileNames { get; set; }
    }
}
