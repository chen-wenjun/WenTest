using Newtonsoft.Json;
using Mi9.Store.Entities.Entities;

namespace Mi9.Store.ViewModels.ViewModels
{
    public class LabelTypeRelationshipViewModel
    {
        [JsonProperty(PropertyName = "code")]
        public string Code { get; set; }

        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }

        [JsonProperty(PropertyName = "shortName")]
        public string ShortName { get; set; }

        [JsonProperty(PropertyName = "defaultPrinter")]
        public PrinterEntity DefaultPrinterEntity { get; set; }

        [JsonProperty(PropertyName = "warehouseUse")]
        public bool WarehouseUse { get; set; }

        [JsonProperty(PropertyName = "storeUse")]
        public bool StoreUse { get; set; }

        [JsonProperty(PropertyName = "mobile")]
        public bool Mobile { get; set; }

        [JsonProperty(PropertyName = "promotionCode")]
        public string PromotionCode { get; set; }

        [JsonProperty(PropertyName = "deleted")]
        public bool Deleted { get; set; }

        [JsonProperty(PropertyName = "label")]
        public string Label { get; set; }

        [JsonProperty(PropertyName = "hasPrice")]
        public bool HasPrice { get; set; }

        [JsonProperty(PropertyName = "enableHasPrice")]
        public bool EnableHasPrice { get; set; }

        [JsonProperty(PropertyName = "noMobile")]
        public bool NoMobilePrinter { get; set; }
    }
}
