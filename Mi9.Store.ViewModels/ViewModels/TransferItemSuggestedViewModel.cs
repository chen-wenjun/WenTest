using Newtonsoft.Json;

namespace Mi9.Store.ViewModels.ViewModels
{
    public class TransferItemSuggestedViewModel
    {
        [JsonProperty(PropertyName = "departmentNumber")]
        public short? DepartmentNumber { get; set; }
        
        [JsonProperty(PropertyName = "sku")]
        public long SKU { get; set; }

        [JsonProperty(PropertyName = "upc")]
        public string UPC { get; set;  }

        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }

        [JsonProperty(PropertyName = "itemSubClass")]
        public short? ItemSubClass { get; set; }

        [JsonProperty(PropertyName = "status")]
        public string Status { get; set; }

        [JsonProperty(PropertyName = "velocityCode")]
        public string VelocityCode { get; set; }

        [JsonProperty(PropertyName = "requestCost")]
        public decimal RequestCost { get; set; }

        [JsonProperty(PropertyName = "requestRetail")]
        public decimal RequestRetail { get; set; }

        [JsonProperty(PropertyName = "requestQtyAvailable")]
        public decimal RequestQtyAvailable { get; set; }

        [JsonProperty(PropertyName = "sendLocationCompoundName")]
        public string SendLocationCompoundName { get; set; }

        [JsonProperty(PropertyName = "sendLocation")]
        public StoreViewModel SendLocation { get; set; }
        
        [JsonProperty(PropertyName = "sourceCost")]
        public decimal SourceCost { get; set; }

        [JsonProperty(PropertyName = "sourceRetail")]
        public decimal SourceRetail { get; set; }

        [JsonProperty(PropertyName = "sourceQtyAvailable")]
        public decimal SourceQtyAvailable { get; set; }

        [JsonProperty(PropertyName = "requestQty")]
        public decimal RequestedQty { get; set; }

        [JsonProperty(PropertyName = "shipQty")]
        public decimal ShipQty { get; set; }

        [JsonProperty(PropertyName = "receivedQty")]
        public decimal ReceivedQty { get; set; }

        [JsonProperty(PropertyName = "damageQty")]
        public decimal DamageQty { get; set; } 
        
        [JsonProperty(PropertyName = "shipMethod")]
        public ShipMethodViewModel ShipMethod { get; set; }

        [JsonProperty(PropertyName = "accepted")]
        public bool Accepted { get; set; }

        [JsonProperty(PropertyName = "vendorId")]
        public string VendorId { get; set; }

        [JsonProperty(PropertyName = "vendorPack")]
        public short? VendUOMQty { get; set; }

        [JsonProperty(PropertyName = "class")]
        public short? Class { get; set; } 
    }
}
