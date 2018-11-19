using System;
using System.Collections.Generic;
using Mi9.Store.ViewModels.Converters;
using Newtonsoft.Json;

namespace Mi9.Store.ViewModels.ViewModels
{
    public class PoPurchaseOrderViewModel
    {
        [JsonProperty(PropertyName = "id")]
        public string PurchaseOrderNumber { get; set; }

        [JsonProperty(PropertyName = "status")]
        public PurchaseOrderStatusViewModel Status { get; set; }

        [JsonProperty(PropertyName = "type")]
        public string Type { get; set; }

        [JsonProperty(PropertyName = "typeTitle")]
        public string TypeTitle { get; set; }
        
        [JsonProperty(PropertyName = "notes")]
        public string Notes { get; set; }

        [JsonProperty(PropertyName = "authorized")]
        public bool Authorized { get; set; }

        [JsonProperty(PropertyName = "canceled")]
        public bool Canceled { get; set; }

        [JsonProperty(PropertyName = "cancellationDate")]
        [JsonConverter(typeof(IsoUtcDateTimeConverter))]
        public DateTime? CancellationDate { get; set; }

        [JsonProperty(PropertyName = "deliveryDate")]
        [JsonConverter(typeof(IsoUtcDateTimeConverter))]
        public DateTime? DeliveryDate { get; set; }

        [JsonProperty(PropertyName = "updatedDate")]
        [JsonConverter(typeof(IsoUtcDateTimeConverter))]
        public DateTime? UpdatedDate { get; set; }

        [JsonProperty(PropertyName = "createdDate")]
        [JsonConverter(typeof(IsoUtcDateTimeConverter))]
        public DateTime? CreatedDate { get; set; }

        [JsonProperty(PropertyName = "orderDate")]
        [JsonConverter(typeof(IsoUtcDateTimeConverter))]
        public DateTime? OrderDate { get; set; }

        [JsonProperty(PropertyName = "isSystemGenerated")]
        public bool IsSystemGenerated { get; set; }

        [JsonProperty(PropertyName = "vendor")]
        public virtual VendorViewModel Vendor { get; set; }

        [JsonProperty(PropertyName = "buyer")]
        public virtual EmployeeViewModel Buyer { get; set; }

        [JsonProperty(PropertyName = "items")]
        public virtual List<PoPurchaseOrderItemViewModel> PurchaseOrderItems { get; set; }

        [JsonProperty(PropertyName = "allowStoreCancellation")]
        public bool AllowStoreCancellation { get; set; }

        [JsonProperty(PropertyName = "allowStoreReactivation")]
        public bool AllowStoreReActivation { get; set; }

        [JsonProperty(PropertyName = "destinationCode")]
        public short? DestinationCode { get; set; }

    }
}