using System;
using Newtonsoft.Json;

namespace Mi9.Store.ViewModels.ViewModels
{
    public class TransferSummaryViewModel
    {
        [JsonProperty(PropertyName = "transferNumber")]
        public string TransferNumber { get; set; }

        [JsonProperty(PropertyName = "sendingLocation")]
        public StoreViewModel SendingLocation { get; set; }

        [JsonProperty(PropertyName = "requestingLocation")]
        public string RequestingLocation { get; set; }

        [JsonProperty(PropertyName = "createdDate")]
        public DateTime? CreatedDate { get; set; }

        [JsonProperty(PropertyName = "skuAmount")]
        public decimal SkuAmount { get; set; }

        [JsonProperty(PropertyName = "totalQty")]
        public decimal TotalQty { get; set; }

        [JsonProperty(PropertyName = "totalCost")]
        public decimal TotalCost { get; set; }

        [JsonProperty(PropertyName = "totalRetail")]
        public decimal TotalRetail { get; set; }

        [JsonProperty(PropertyName = "totalMargin")]
        public decimal TotalMargin
        {
            get
            {
                return TotalRetail != 0 
                    ? (TotalRetail - TotalCost) / TotalRetail 
                    : 0;
            }
        }

        [JsonProperty(PropertyName = "shipMethod")]
        public ShipMethodViewModel ShipMethod { get; set; }

        [JsonProperty(PropertyName = "accepted")]
        public bool Accepted { get; set; }
   
    }
}
