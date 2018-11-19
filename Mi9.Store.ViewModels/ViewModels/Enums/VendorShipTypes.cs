using System.Collections.Generic;
using System.ComponentModel;
using Newtonsoft.Json;

namespace Mi9.Store.ViewModels.ViewModels.Enums
{
    public enum VendorShipTypes
    {
        [Description("P")]
        Prepaid,
        [Description("B")]
        Backhaul,
        [Description("C")]
        Collect
    }

    public class VendorShipType
    {
        [JsonProperty(PropertyName = "value")]
        public string Value { get; set; }
        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }
    }

    public class VendorShipTypesCatalog
    {
        [JsonProperty(PropertyName = "items")]
        public IList<VendorShipType> Items { get; set; }

        public VendorShipTypesCatalog()
        {
            Items = new List<VendorShipType>
                {
                    new VendorShipType
                        {
                            Value = "P",
                            Description = "catalogs.vendorShipTypes.prepaid"
                        },
                    new VendorShipType
                        {
                            Value = "B",
                            Description = "catalogs.vendorShipTypes.backhaul"
                        },
                    new VendorShipType
                        {
                            Value = "C",
                            Description = "catalogs.vendorShipTypes.collect"
                        }
                };
        }
    }
}
