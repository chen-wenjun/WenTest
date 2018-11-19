using System.Collections.Generic;
using System.ComponentModel;
using Newtonsoft.Json;

namespace Mi9.Store.ViewModels.ViewModels.Enums
{
    public enum VendorStatuses
    {
        [Description("A")]
        Active,
        [Description("I")]
        Inactive
    }

    public class VendorStatus
    {
        [JsonProperty(PropertyName = "value")]
        public string Value { get; set; }
        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }
    }

    public class VendorStatusCatalog
    {
        [JsonProperty(PropertyName = "items")]
        public IList<VendorStatus> Items { get; set; }

        public VendorStatusCatalog()
        {
            Items = new List<VendorStatus>
                {
                    new VendorStatus
                        {
                            Value = "A",
                            Description = "catalogs.vendorStatus.active"
                        },
                    new VendorStatus
                        {
                            Value = "I",
                            Description = "catalogs.vendorStatus.inactive"
                        }
                };
        }
    }
}
