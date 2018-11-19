using System.Collections.Generic;
using System.ComponentModel;
using Newtonsoft.Json;

namespace Mi9.Store.ViewModels.ViewModels.Enums
{
    public enum PurchaseOrderIsSystemGeneratedTypes
    {
        [Description("0")]
        User,
        [Description("1")]
        SystemSOQ
    }

    public class PurchaseOrderIsSystemGeneratedType
    {
        [JsonProperty(PropertyName = "value")]
        public bool Value { get; set; }
        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }
    }

    public class PurchaseOrderIsSystemGeneratedTypeCatalog
    {
        [JsonProperty(PropertyName = "items")]
        public IList<PurchaseOrderIsSystemGeneratedType> Items { get; set; }

        public PurchaseOrderIsSystemGeneratedTypeCatalog()
        {
            Items = new List<PurchaseOrderIsSystemGeneratedType>
                {
                    new PurchaseOrderIsSystemGeneratedType
                        {
                            Value = false,
                            Description = "catalogs.purchaseOrderIsSystemGeneratedByType.user"
                        },
                    new PurchaseOrderIsSystemGeneratedType
                        {
                            Value = true,
                            Description = "catalogs.purchaseOrderIsSystemGeneratedByType.systemSOQ"
                        }
                };
        }
    }
}
