using System;
using Newtonsoft.Json;

namespace Mi9.Store.ViewModels.ViewModels
{
    
    public class VendorViewModel
    {
        [JsonProperty(PropertyName = "id")]
        public string VendorId { get; set; }

        [JsonProperty(PropertyName = "suffix")]
        public byte VendorSuffix { get; set; }

        [JsonProperty(PropertyName = "name")]
        public string VendorName { get; set; }

        [JsonProperty(PropertyName = "department")]
        public DepartmentViewModel Department { get; set; }

        [JsonProperty(PropertyName = "isActive")]
        public bool IsActive { get; set; }

        [JsonProperty(PropertyName = "contact")]
        public string ContactPerson { get; set; }

        [JsonProperty(PropertyName = "contact1")]
        public VendorContactViewModel ContactPrimary { get; set; }

        [JsonProperty(PropertyName = "contact2")]
        public VendorContactViewModel ContactSecondary { get; set; }

        [JsonProperty(PropertyName = "soPrimaryContact")]
        public VendorContactViewModel SoPrimaryContact { get; set; }

        [JsonProperty(PropertyName = "soSecondaryContact")]
        public VendorContactViewModel SoSecondaryContact { get; set; }

        [JsonProperty(PropertyName = "address")]
        public VendorAddressViewModel Address { get; set; }
        
        [JsonProperty(PropertyName = "negotiatedLeadTime")]
        public short? VendNegoDays { get; set; }

        [JsonProperty(PropertyName = "ext")]
        public string Extended { get; set; }

        [JsonProperty(PropertyName = "isSpecialOrder")]
        public bool SpecificationsRequired { get; set; }

        public VendorConditionsViewModel Conditions { get; set; }

        [JsonProperty(PropertyName = "blockReason")]
        public string BlockReason { get; set; }

        [JsonProperty(PropertyName = "minQuantity")]
        public int? MinCollUnits { get; set; } //VendorMinimumQuantity

        [JsonProperty(PropertyName = "minCost")]
        public int? MinCollDollr { get; set; } //VendorMinimumCost

        [JsonProperty(PropertyName = "minWeight")]
        public int? MinWeight { get; set; } //VendorMinimumQuantity

        [JsonProperty(PropertyName = "minCube")]
        public int? MinCube { get; set; } //VendorMinimumCost

        [JsonProperty(PropertyName = "orderCycle")]
        public bool OrderCycle { get; set; }

        [JsonProperty(PropertyName = "orderSchDays")]
        public short OrderSchDays { get; set; }

        [JsonProperty(PropertyName = "nextOrdrDate")]
        public DateTime? NextOrdrDate { get; set; }

        [JsonProperty(PropertyName = "rtvConfiguration")]
        public VendorRTVConfigurationViewModel RTVConfiguration { get; set; }

    }
}