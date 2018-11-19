using System.Collections.Generic;
using System.ComponentModel;
using Newtonsoft.Json;

namespace Mi9.Store.ViewModels.ViewModels.Enums
{
    public enum ShipmentStatuses
    {
        [Description("C")]
        Confirmed,
        [Description("F")]
        Finished,
        [Description("P")]
        Pending,
        [Description("S")]
        Scanning
    }

    public class ShipmentStatus
    {
        [JsonProperty(PropertyName = "value")]
        public string Value { get; set; }
        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }
    }

    public class ShipmentStatusCatalog
    {
        [JsonProperty(PropertyName = "items")]
        public IList<ShipmentStatus> Items { get; set; }

        public ShipmentStatusCatalog()
        {
            Items = new List<ShipmentStatus>
                {
                    new ShipmentStatus
                        {
                            Value = "C",
                            Description = "catalogs.shipmentStatus.confirmed"
                        },
                    new ShipmentStatus
                        {
                            Value = "F",
                            Description = "catalogs.shipmentStatus.finished"
                        },
                    new ShipmentStatus
                        {
                            Value = "P",
                            Description = "catalogs.shipmentStatus.pending"
                        },
                    new ShipmentStatus
                        {
                            Value = "S",
                            Description = "catalogs.shipmentStatus.scanning"
                        }
                };
        }
    }
}
