using Newtonsoft.Json;

namespace Mi9.Store.ViewModels.ViewModels
{
    
    public class InventoryInquiryItemViewModel
    {
        [JsonProperty(PropertyName = "location")]
        public DestinationViewModel Location { get; set; }

        [JsonProperty(PropertyName = "isFractionalQuantity")]
        public bool IsFractionalQuantity { get; set; }

        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }

        [JsonProperty(PropertyName = "number")]
        public long Sku { get; set; }

        [JsonProperty(PropertyName = "status")]
        public string Status { get; set; }

        [JsonProperty(PropertyName = "onOrder")]
        public decimal OnOrder { get; set; }

        [JsonProperty(PropertyName = "requestQuantity")]
        public decimal? RequestQty { get; set; }

        [JsonProperty(PropertyName = "receivedQuantity")]
        public decimal ReceivedQuantity { get; set; }

        [JsonProperty(PropertyName = "damagedQuantity")]
        public decimal DamagedQuantity { get; set; }

        [JsonProperty(PropertyName = "shipQuantity")]
        public decimal QtyShipped { get; set; }

        [JsonProperty(PropertyName = "weekOfInventory")]
        public decimal WeekOfInventory { get; set; }

        [JsonProperty(PropertyName = "velocityCode")]
        public string VelocityCode { get; set; }

        [JsonProperty(PropertyName = "vendorPack")]
        public short VendorPack { get; set; }

        [JsonProperty(PropertyName = "requestStoreCost")]
        public decimal RequestStoreCost { get; set; }

        [JsonProperty(PropertyName = "requestStoreRetail")]
        public decimal RequestStorePrice { get; set; }

        [JsonProperty(PropertyName = "sourceStoreCost")]
        public decimal SourceStoreCost { get; set; }

        [JsonProperty(PropertyName = "sourceStoreRetail")]
        public decimal SourceStorePrice { get; set; }

        [JsonProperty(PropertyName = "requestStoreAvailableQuantity")]
        public decimal RequestStoreAvailable { get; set; }

        [JsonProperty(PropertyName = "department")]
        public short Department { get; set; }

        [JsonProperty(PropertyName = "sourceStoreAvailableQuantity")]
        public decimal SourceStoreAvailable { get; set; }

        [JsonProperty(PropertyName = "pendingQuantity")]
        public decimal PendingQty { get; set; }

        [JsonProperty(PropertyName = "class")]
        public short? Class { get; set; }

        [JsonProperty(PropertyName = "subClass")]
        public short? SubClass { get; set; }
    }
}