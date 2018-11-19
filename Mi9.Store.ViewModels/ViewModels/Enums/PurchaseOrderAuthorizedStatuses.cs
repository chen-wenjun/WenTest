using System.Collections.Generic;
using System.ComponentModel;
using Newtonsoft.Json;

namespace Mi9.Store.ViewModels.ViewModels.Enums
{
    public enum PurchaseOrderAuthorizedStatuses
    {
        [Description("0")]
        Not_Authorized,
        [Description("1")]
        Authorized
    }

    public class PurchaseOrderAuthorizedStatus
    {
        [JsonProperty(PropertyName = "value")]
        public bool Value { get; set; }
        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }
    }

    public class PurchaseOrderAuthorizedStatusCatalog
    {
        [JsonProperty(PropertyName = "items")]
        public IList<PurchaseOrderAuthorizedStatus> Items { get; set; }

        public PurchaseOrderAuthorizedStatusCatalog()
        {
            Items = new List<PurchaseOrderAuthorizedStatus>
                {
                    new PurchaseOrderAuthorizedStatus
                        {
                            Value = false,
                            Description = "catalogs.purchaseOrderAuthorizedStatus.unAuthorized"
                        },
                    new PurchaseOrderAuthorizedStatus
                        {
                            Value = true,
                            Description = "catalogs.purchaseOrderAuthorizedStatus.authorized"
                        }
                };
        }
    }
}
