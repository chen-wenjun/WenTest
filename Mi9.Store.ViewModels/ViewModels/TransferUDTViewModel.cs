
using System;
using System.Collections.Generic;
using System.Linq;
using Mi9.Store.ViewModels.Converters;
using Newtonsoft.Json;

namespace Mi9.Store.ViewModels.ViewModels
{
    public class TransferUdtViewModel
    {
        [JsonProperty(PropertyName = "number")]
        public string TransferNumber { get; set; }

        [JsonProperty(PropertyName = "toBeShippedOn")]
        [JsonConverter(typeof(IsoUtcDateTimeConverter))]
        public DateTime? ReqShipDate { get; set; }

        [JsonProperty(PropertyName = "reason")]
        public ReasonViewModel Reason { get; set; }
        
        [JsonProperty(PropertyName = "shipMethod")]
        public ShipMethodViewModel ShipMethod { get; set; }

        [JsonProperty(PropertyName = "shipmentReference")]
        public string ShipmentRef { get; set; }

        [JsonProperty(PropertyName = "driverReference")]
        public string DriverRef { get; set; }

        [JsonProperty(PropertyName = "truckNumber")]
        public string TruckNumber { get; set; }
        
        [JsonProperty(PropertyName = "status")]
        public TransferStatusViewModel Status { get; set; }

        [JsonProperty(PropertyName = "items")]
        public IEnumerable<InventoryInquiryItemViewModel> Items { get; set; }

        [JsonProperty(PropertyName = "notes")]
        public string Note { get; set; }
        
        [JsonProperty(PropertyName = "createUser")]
        public int? CreateEmp { get; set; }

        [JsonProperty(PropertyName = "createDate")]
        [JsonConverter(typeof(IsoUtcDateTimeConverter))]
        public DateTime? DateCreated { get; set; }

        [JsonProperty(PropertyName = "amendUser")]
        public int? AmendEmp { get; set; }
        
        [JsonProperty(PropertyName = "amendDate")]
        [JsonConverter(typeof(IsoUtcDateTimeConverter))]
        public DateTime? DateLastUpd { get; set; }

        [JsonProperty(PropertyName = "approveUser")]
        public int? ApproveEmp { get; set; }

        [JsonProperty(PropertyName = "approveDate")]
        [JsonConverter(typeof(IsoUtcDateTimeConverter))]
        public DateTime? DateApproved { get; set; }
        
        [JsonProperty(PropertyName = "shipUser")]
        public int? ShippedEmp { get; set; }

        [JsonProperty(PropertyName = "shipDate")]
        [JsonConverter(typeof(IsoUtcDateTimeConverter))]
        public DateTime? DateShipped { get; set; }

        [JsonProperty(PropertyName = "voidUser")]
        public int? VoidedEmp { get; set; }

        [JsonProperty(PropertyName = "voidDate")]
        [JsonConverter(typeof(IsoUtcDateTimeConverter))]
        public DateTime? DateVoided { get; set; }

        [JsonProperty(PropertyName = "suggestionNumber")]
        public string OrigSuggestionNumber { get; set; }

        [JsonProperty(PropertyName = "skuCounter")]
        public int SkuCounter
        {
            get
            {
                return Items.Count();
            }
        }

        [JsonProperty(PropertyName = "totalQty")]
        public decimal TotalQuantity
        {
            get
            {
                var sum = this.Items.Sum(x => x.RequestQty);
                return sum.HasValue ? sum.Value : 0;
            }
        }

        [JsonProperty(PropertyName = "totalCost")]
        public decimal TotalCost
        {
            get
            {
                var sum = this.Items.Sum(x => x.SourceStoreCost * x.RequestQty);
                return sum.HasValue ? sum.Value : 0;
            }
        }

        [JsonProperty(PropertyName = "totalRetail")]
        public decimal TotalRetail
        {
            get
            {
                var sum = this.Items.Sum(x => x.SourceStorePrice * x.RequestQty);
                return sum.HasValue ? sum.Value : 0;
            }
        }

        [JsonProperty(PropertyName = "margin")]
        public decimal Margin
        {
            get
            {
                var margin = 0.0m;
                if (this.TotalRetail != 0)
                {
                    margin = (this.TotalRetail - this.TotalCost) / this.TotalRetail;
                }

                return margin;
            }
        }

        [JsonProperty(PropertyName = "sendingLocation")]
        public DestinationViewModel SendingLocation { get; set; }

        [JsonProperty(PropertyName = "requestLocation")]
        public StoreViewModel RequestLocation { get; set; }
    }
}
