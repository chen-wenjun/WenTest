using System.Collections.Generic;
using System.ComponentModel;
using Newtonsoft.Json;

namespace Mi9.Store.ViewModels.ViewModels.Enums
{
    public enum PurchaseOrderCancelStatuses
    {
        [Description("CP")]
        CancelInProgress,
        [Description("CN")]
        CancelNotShipped,
        [Description("CR")]
        CancelReceived,
        [Description("RC")]
        CanceledReSold,
        
    }

    public class PurchaseOrderCancelStatus
    {
        [JsonProperty(PropertyName = "value")]
        public string Value { get; set; }
        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }
    }

    public class PurchaseOrderCancelStatusCatalog
    {
        [JsonProperty(PropertyName = "items")]
        public IList<PurchaseOrderCancelStatus> Items { get; set; }

        public PurchaseOrderCancelStatusCatalog()
        {
            Items = new List<PurchaseOrderCancelStatus>
                {
                    new PurchaseOrderCancelStatus
                        {
                            Value = "CP",
                            Description = "catalogs.purchaseOrderCancelStatus.cancellationInProgress"
                        },
                    new PurchaseOrderCancelStatus
                        {
                            Value = "CN",
                            Description = "catalogs.purchaseOrderCancelStatus.cancelledNotShipped"
                        },
                        new PurchaseOrderCancelStatus
                        {
                            Value = "CR",
                            Description = "catalogs.purchaseOrderCancelStatus.cancelledReceived"
                        },
                    new PurchaseOrderCancelStatus
                        {
                            Value = "RC",
                            Description = "catalogs.purchaseOrderCancelStatus.cancelledReSold"
                        }
                };
        }
    }
}
