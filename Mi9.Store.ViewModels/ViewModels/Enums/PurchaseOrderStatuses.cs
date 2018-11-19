using System.Collections.Generic;
using System.ComponentModel;
using Newtonsoft.Json;

namespace Mi9.Store.ViewModels.ViewModels.Enums
{
    public enum PurchaseOrderStatuses
    {
        [Description("A")]
        AutomatedReq,
        [Description("B")]
        BOOrderCancelled,
        [Description("C")]
        ManualCancelled,
        [Description("F")]
        ComplFinal,
        [Description("H")]
        HoldForCorrections,
        [Description("P")]
        ActivePO,
        [Description("R")]
        Requisition,
        [Description("T")]
        TrafficAuthorization,
    }

    public class PurchaseOrderStatus
    {
        [JsonProperty(PropertyName = "value")]
        public string Value { get; set; }
        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }
    }

    public class PurchaseOrderStatusCatalog
    {
        [JsonProperty(PropertyName = "items")]
        public IList<PurchaseOrderStatus> Items { get; set; }

        public PurchaseOrderStatusCatalog()
        {
            Items = new List<PurchaseOrderStatus>
                {
                    new PurchaseOrderStatus
                        {
                            Value = "A",
                            Description = "catalogs.purchaseOrderStatus.automatedReq"
                        },
                    new PurchaseOrderStatus
                        {
                            Value = "B",
                            Description = "catalogs.purchaseOrderStatus.boOrderCancelled"
                        },
                        new PurchaseOrderStatus
                        {
                            Value = "C",
                            Description = "catalogs.purchaseOrderStatus.manualCancelled"
                        },
                    new PurchaseOrderStatus
                        {
                            Value = "F",
                            Description = "catalogs.purchaseOrderStatus.complFinal"
                        },
                         new PurchaseOrderStatus
                        {
                            Value = "H",
                            Description = "catalogs.purchaseOrderStatus.holdForCorrections"
                        },
                        new PurchaseOrderStatus
                        {
                            Value = "P",
                            Description = "catalogs.purchaseOrderStatus.activePO"
                        },
                        new PurchaseOrderStatus
                        {
                            Value = "R",
                            Description = "catalogs.purchaseOrderStatus.requisition"
                        },
                    new PurchaseOrderStatus
                        {
                            Value = "T",
                            Description = "catalogs.purchaseOrderStatus.trafficAuthorization"
                        }
                };
        }
    }
}
