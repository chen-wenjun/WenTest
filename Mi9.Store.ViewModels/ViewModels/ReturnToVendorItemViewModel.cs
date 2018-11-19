using Newtonsoft.Json;

namespace Mi9.Store.ViewModels.ViewModels
{
    public class ReturnToVendorItemViewModel
    {
        [JsonProperty(PropertyName = "rtvNumber")]
        public long RTVNumber { get; set; }

        [JsonProperty(PropertyName = "sku")]
        public long SKU { get; set; }

        [JsonProperty(PropertyName = "reason")]
        public byte ReasonCode { get; set; }

        [JsonProperty(PropertyName = "rtvQuantity")]
        public decimal QtyRetn { get; set; }

        [JsonProperty(PropertyName = "unitCost")]
        public decimal AvgCost { get; set; }

        [JsonProperty(PropertyName = "unitRetail")]
        public decimal RetailPrice { get; set; }

        [JsonProperty(PropertyName = "adjType")]
        public string InventoryAdjustType { get; set; }

        [JsonProperty(PropertyName = "notes")]
        public string Notes { get; set; }

        [JsonProperty(PropertyName = "upc")]
        public string UPC { get; set; }

        [JsonProperty(PropertyName = "isReceived")]
        public bool IsReceived
        {
            get
            {
                return (QtyRetn - QtyReceive == 0);
            }
        }

        [JsonProperty(PropertyName = "recQuantity")]
        public decimal QtyReceive { get; set; }
        
        [JsonProperty(PropertyName = "departmentNumber")]
        public short? DepartmentNumber { get; set; }

        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }

        [JsonProperty(PropertyName = "udm")]
        public string UDM { get; set; }

        [JsonProperty(PropertyName = "currentQuantity")]
        public decimal CurrentQuantity { get; set; }

        [JsonProperty(PropertyName = "rtvCost")]
        public decimal RtvCost { get { return AvgCost * QtyRetn; } }

        [JsonProperty(PropertyName = "rtvRetail")]
        public decimal RtvRetail { get { return RetailPrice * QtyRetn; } }

        [JsonProperty(PropertyName = "status")]
        public bool Status { get; set; }

        [JsonProperty(PropertyName = "department")]
        public string Department { get; set; }

        [JsonProperty(PropertyName = "deleted")]
        public bool IsDeleted { get; set; }
    }
}