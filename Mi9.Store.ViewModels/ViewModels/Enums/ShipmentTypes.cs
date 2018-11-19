using System.Collections.Generic;
using System.ComponentModel;
using Newtonsoft.Json;

namespace Mi9.Store.ViewModels.ViewModels.Enums
{
    public enum ShipmentTypes
    {
        [Description("C")]
        CrossDockTransfer,
        [Description("W")]
        WarehouseTransfer,
        [Description("S")]
        StoreTransfer,
        [Description("P")]
        PurchaseOrder
    }

    public class ShipmentType
    {
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }
        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }
    }

    public class ShipmentTypeCatalog
    {
        [JsonProperty(PropertyName = "items")]
        public IList<ShipmentType> Items { get; set; }

        public ShipmentTypeCatalog()
        {
            Items = new List<ShipmentType>
                {
                    new ShipmentType
                        {
                            Id = "C",
                            Description = "catalogs.shipmentType.crossDockTransfer"
                        },
                    new ShipmentType
                        {
                            Id = "W",
                            Description = "catalogs.shipmentType.warehouseTransfer"
                        },
                    new ShipmentType
                        {
                            Id = "S",
                            Description = "catalogs.shipmentType.storeTransfer"
                        },
                    new ShipmentType
                        {
                            Id = "P",
                            Description = "catalogs.shipmentType.purchaseOrder"
                        }
                };
        }
    }
}
