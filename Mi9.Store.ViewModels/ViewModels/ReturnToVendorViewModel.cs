using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Mi9.Store.ViewModels.ViewModels
{
    public class ReturnToVendorViewModel
    {
        [JsonProperty(PropertyName = "rtvNumber")]
        public long RTVNumber { get; set; }

        [JsonProperty(PropertyName = "vendor")]
        public VendorViewModel Vendor { get; set; }

        [JsonProperty(PropertyName = "raNumber")]
        public string RtnAuthNumber { get; set; }

        [JsonProperty(PropertyName = "licensePlate")]
        public string VehicleLicense { get; set; }

        [JsonProperty(PropertyName = "driverName")]
        public string DriverRef { get; set; }

        [JsonProperty(PropertyName = "authorizer")]
        public string Authorizer { get; set; }

        [JsonProperty(PropertyName = "destroyInStore")]
        public bool DestroyInStore { get; set; }

        [JsonProperty(PropertyName = "creationDate")]
        public DateTime? DateCreated { get; set; }

        [JsonProperty(PropertyName = "confirmedDate")]
        public DateTime? DateClosed { get; set; }

        [JsonProperty(PropertyName = "createByUser")]
        public int CreateEmplNo { get; set; }

        [JsonProperty(PropertyName = "createByUserName")]
        public string CreateEmplName { get; set; }

        [JsonProperty(PropertyName = "confirmedByUser")]
        public int? CloseEmplNo { get; set; }

        [JsonProperty(PropertyName = "confirmedByUserName")]
        public string CloseEmplName { get; set; }

        [JsonProperty(PropertyName = "status")]
        public string Status { get; set; }

        [JsonProperty(PropertyName = "notes")]
        public string Notes { get; set; }

        [JsonProperty(PropertyName = "canceledDate")]
        public DateTime? DateCanceled { get; set; }

        [JsonProperty(PropertyName = "canceledByUser")]
        public int? CancelEmplNo { get; set; }

        [JsonProperty(PropertyName = "canceledByUserName")]
        public string CancelEmplName { get; set; }

        [JsonProperty(PropertyName = "category")]
        public int? CategoryId { get; set; }

        [JsonProperty(PropertyName = "type")]
        public ReturnToVendorTypeViewModel Type { get; set; }

        [JsonProperty(PropertyName = "items")]
        public ICollection<ReturnToVendorItemViewModel> Items { get; set; }  
    }

    public class SearchReturnToVendorViewModel: ReturnToVendorViewModel
    {
        [JsonProperty(PropertyName = "creationDateEnd")]
        public DateTime? CreateDateEnd { get; set; }

        [JsonProperty(PropertyName = "confirmedDateEnd")]
        public DateTime? CloseDateEnd { get; set; }

        [JsonProperty(PropertyName = "statusCodes")]
        public string StatusCodes { get; set; }
    }
}