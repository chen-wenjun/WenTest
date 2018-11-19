using System.Collections.Generic;
using System.ComponentModel;
using Newtonsoft.Json;

namespace Mi9.Store.ViewModels.ViewModels.Enums
{
    public enum ShipmentMethods
    {
        [Description("ENVIAR")]
        DeliveredBySourceStore = 1,
        [Description("RECOGER")]
        RequestingStorePickUp,
        [Description("MDC-MTY")]
        MDCMty,
        [Description("MDC-MEX")]
        MDCMex
    }

    public class ShipmentMethod
    {
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }
        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }
    }

    public class ShipmentMethodCatalog
    {
        [JsonProperty(PropertyName = "items")]
        public IList<ShipmentMethod> Items { get; set; }

        public ShipmentMethodCatalog()
        {
            Items = new List<ShipmentMethod>()
                {
                    new ShipmentMethod
                    {
                        Id = "ENVIAR",
                        Description = "catalogs.shipMethod.deliveredBySourceStore"
                    },
                    new ShipmentMethod
                    {
                        Id = "RECOGER",
                        Description = "catalogs.shipMethod.requestingStorePickUp"
                    },
                    new ShipmentMethod
                    {
                        Id = "MDC-MTY",
                        Description = "catalogs.shipMethod.mDCMty"
                    },
                    new ShipmentMethod
                    {
                        Id = "MDC-MEX",
                        Description = "catalogs.shipMethod.mDCMex"
                    }
                };
        }
    }

    
}
