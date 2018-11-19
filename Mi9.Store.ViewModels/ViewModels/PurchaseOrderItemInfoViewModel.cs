using Newtonsoft.Json;

namespace Mi9.Store.ViewModels.ViewModels
{
    public class PurchaseOrderItemInfoViewModel
    {
        [JsonProperty(PropertyName = "purchaseOrderNumber")]
        public string PurchaseOrderNumber { get; set; }

        [JsonProperty(PropertyName = "skuId")]
        public long SkuId { get; set; }

        [JsonProperty(PropertyName = "last4WeeksSales")]
        public decimal Last4WeeksSales { get; set; }

        [JsonProperty(PropertyName = "last13WeeksSales")]
        public decimal Last13WeeksSales { get; set; }

        [JsonProperty(PropertyName = "yearToDaySales")]
        public decimal YearToDaySales { get; set; }

        [JsonProperty(PropertyName = "onOrder")]
        public decimal OnOrder { get; set; }

        [JsonProperty(PropertyName = "classNo")]
        public short ClassNo { get; set; }

        [JsonProperty(PropertyName = "subClass")]
        public short SubClass { get; set; }

        [JsonProperty(PropertyName = "deptNo")]
        public short DeptNo { get; set; }

        [JsonProperty(PropertyName = "modelStock")]
        public int ModelStock { get; set; }

        [JsonProperty(PropertyName = "weeksOfInventory")]
        public decimal WeeksOfInventory
        {
            get
            {
                return (Last13WeeksSales / (decimal)13.0);
            }
        }
    }
}